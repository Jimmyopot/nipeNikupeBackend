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
    }
}
