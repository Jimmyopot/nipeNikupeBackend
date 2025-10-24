using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NipeNikupe.Data;
using System.Globalization;

namespace NipeNikupe.Controllers
{
    [ApiController]
    [Route("api/utils")]
    public class UtilsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UtilsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("GetAllCounties")]
        public async Task<IActionResult> GetAllCounties()
        {
            var counties = await _context.Counties.OrderBy(c => c.Id).ToListAsync();
            return Ok(counties);
        }

        [HttpGet("GetCountyById/{id}")]
        public async Task<IActionResult> GetCountyById(int id)
        {
            var county = await _context.Counties.FindAsync(id);
            if (county == null)
                return NotFound(new { message = "County not found." });
            return Ok(county);
        }

        // 1. Skill Search for Autocomplete
        [HttpGet("SearchSkills")]
        public async Task<IActionResult> SearchSkills([FromQuery] string query, [FromQuery] int maxResults = 10)
        {
            if (string.IsNullOrWhiteSpace(query))
                return BadRequest("Query is required.");

            query = query.Trim().ToLower(CultureInfo.InvariantCulture);

            // Get all skill names sorted alphabetically
            var skills = await _context.Skills
                .OrderBy(s => s.Name)
                .Select(s => s.Name)
                .ToListAsync();

            // Binary search isn’t ideal for substring matching (it’s best for prefix searches),
            // but we’ll combine prefix efficiency with substring fallback.

            var results = new List<string>();

            // 1️⃣ Try to find prefix matches first (efficient)
            foreach (var skill in skills)
            {
                var lowerSkill = skill.ToLower(CultureInfo.InvariantCulture);
                if (lowerSkill.StartsWith(query))
                {
                    results.Add(skill);
                    if (results.Count >= maxResults)
                        return Ok(results);
                }
            }

            // 2️⃣ If not enough results, also find matches where any *word* contains the query
            if (results.Count < maxResults)
            {
                foreach (var skill in skills)
                {
                    var lowerSkill = skill.ToLower(CultureInfo.InvariantCulture);
                    var words = lowerSkill.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    if (words.Any(word => word.Contains(query)) && !results.Contains(skill))
                    {
                        results.Add(skill);
                        if (results.Count >= maxResults)
                            break;
                    }
                }
            }

            return Ok(results);
        }

        // 2. API to Return Skills by Category
        [HttpGet("GetSkillsByCategory")]
        public async Task<IActionResult> GetSkillsByCategory([FromQuery] string category, [FromQuery] bool sort = true)
        {
            if (string.IsNullOrWhiteSpace(category))
                return BadRequest("Category is required.");

            // Normalize both sides to lowercase for case-insensitive comparison
            var normalizedCategory = category.Trim().ToLower();

            var query = _context.Skills
                .Where(s => s.Category.ToLower() == normalizedCategory);

            if (sort)
                query = query.OrderBy(s => s.Name);

            var skills = await query.ToListAsync();
            return Ok(skills);
        }

        [HttpGet("GetSkillsGroupedByCategory")]
        public async Task<IActionResult> GetSkillsGroupedByCategory()
        {
            var skills = await _context.Skills
                .OrderBy(s => s.Category)
                .ThenBy(s => s.Name)
                .ToListAsync();

            var grouped = skills
                .GroupBy(s => s.Category)
                .ToDictionary(
                    g => g.Key,
                    g => g.Select(skill => new {
                        skill.Id,
                        skill.Name,
                        skill.CreatedAt
                    }).ToList()
                );

            return Ok(grouped);
        }

        // -------------------------
        // New endpoint requested:
        // GET /api/skills/search?skill=plumbing&county=Nairobi
        // GET SearchUsersBySkillAndCounty?skill=plumbing&county=Nairobi
        // - skill (required)
        // - county (optional)
        // Returns matching users (profile & contact) who offer the skill, optionally filtered by county.
        // -------------------------

        [HttpGet("SearchUsersBySkillAndCounty")]
        public async Task<IActionResult> SearchUsersBySkillAndCounty([FromQuery] string skill, [FromQuery] string? county = null)
        {
            if (string.IsNullOrWhiteSpace(skill))
                return BadRequest("Query parameter 'skill' is required.");

            var search = skill.Trim().ToLowerInvariant();
            string? normalizedCounty = string.IsNullOrWhiteSpace(county) ? null : county.Trim().ToLowerInvariant();

            // Load users. If you expect many users, replace with a paged query or normalized UserSkill join table.
            var users = await _context.SignUps.ToListAsync();

            var results = new List<object>();

            foreach (var user in users)
            {
                // Ensure user has skills
                if (user.Skills == null || user.Skills.Count == 0)
                    continue;

                // Find matching skills for this user (case-insensitive, partial match)
                var matchedSkill = user.Skills
                    .Where(s => !string.IsNullOrWhiteSpace(s))
                    .Select(s => new { Raw = s, Lower = s.Trim().ToLowerInvariant() })
                    .FirstOrDefault(s => s.Lower.Contains(search));

                if (matchedSkill == null)
                    continue;

                // If county filter provided, try to match against user's CityOrTown or LocalityOrArea (sign-up model does not have a 'County' field)
                if (normalizedCounty != null)
                {
                    var city = user.CityOrTown?.Trim().ToLowerInvariant();
                    var locality = user.LocalityOrArea?.Trim().ToLowerInvariant();

                    // Match if county equals or is contained in either city or locality (helps with "Nairobi" and "Westlands" cases)
                    var countyMatches =
                        (!string.IsNullOrWhiteSpace(city) && city.Contains(normalizedCounty)) ||
                        (!string.IsNullOrWhiteSpace(locality) && locality.Contains(normalizedCounty));

                    if (!countyMatches)
                        continue;
                }

                // Build result item
                results.Add(new
                {
                    userId = user.Id.ToString(),
                    fullName = user.FullName,
                    skill = matchedSkill.Raw,
                    county = user.CityOrTown ?? string.Empty,
                    country = user.Country ?? string.Empty,
                    contact = user.Email
                });
            }

            // ********** Log this search for analytics **********
            try
            {
                var userIdClaim = User?.FindFirst("userId")?.Value; // may be null for anonymous
                var ip = HttpContext.Connection.RemoteIpAddress?.ToString();
                var ua = Request.Headers["User-Agent"].FirstOrDefault();

                var log = new NipeNikupe.Models.SkillSearchLog
                {
                    Skill = skill.Trim(),
                    County = county,
                    UserId = userIdClaim,
                    IpAddress = ip,
                    UserAgent = ua,
                    ResultsCount = results.Count,
                    SearchTimeUtc = DateTime.UtcNow
                };
                _context.SkillSearchLogs.Add(log);
                // await to ensure log persisted; consider fire-and-forget in high-throughput scenarios
                await _context.SaveChangesAsync();
            }
            catch
            {
                // logging must not break the API — swallow errors or write to fallback logger
            }

            return Ok(results);
        }
    }
        }
