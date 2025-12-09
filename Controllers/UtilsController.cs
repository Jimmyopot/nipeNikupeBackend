//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using NipeNikupe.Data;
//using System.Globalization;
//using System.Security.Claims;

//namespace NipeNikupe.Controllers
//{
//    [ApiController]
//    [Route("api/utils")]
//    public class UtilsController : ControllerBase
//    {
//        private readonly AppDbContext _context;

//        public UtilsController(AppDbContext context)
//        {
//            _context = context;
//        }

//        [HttpGet("GetAllCounties")]
//        public async Task<IActionResult> GetAllCounties()
//        {
//            var counties = await _context.Counties.OrderBy(c => c.Id).ToListAsync();
//            return Ok(counties);
//        }

//        [HttpGet("GetCountyById/{id}")]
//        public async Task<IActionResult> GetCountyById(int id)
//        {
//            var county = await _context.Counties.FindAsync(id);
//            if (county == null)
//                return NotFound(new { message = "County not found." });
//            return Ok(county);
//        }

//        // 1. Skill Search for Autocomplete
//        [HttpGet("SearchSkills")]
//        public async Task<IActionResult> SearchSkills([FromQuery] string query, [FromQuery] int maxResults = 10)
//        {
//            if (string.IsNullOrWhiteSpace(query))
//                return BadRequest("Query is required.");

//            query = query.Trim().ToLower(CultureInfo.InvariantCulture);

//            // Get all skill names sorted alphabetically
//            var skills = await _context.Skills
//                .OrderBy(s => s.Name)
//                .Select(s => s.Name)
//                .ToListAsync();

//            // Binary search isn’t ideal for substring matching (it’s best for prefix searches),
//            // but we’ll combine prefix efficiency with substring fallback.

//            var results = new List<string>();

//            // 1️⃣ Try to find prefix matches first (efficient)
//            foreach (var skill in skills)
//            {
//                var lowerSkill = skill.ToLower(CultureInfo.InvariantCulture);
//                if (lowerSkill.StartsWith(query))
//                {
//                    results.Add(skill);
//                    if (results.Count >= maxResults)
//                        return Ok(results);
//                }
//            }

//            // 2️⃣ If not enough results, also find matches where any *word* contains the query
//            if (results.Count < maxResults)
//            {
//                foreach (var skill in skills)
//                {
//                    var lowerSkill = skill.ToLower(CultureInfo.InvariantCulture);
//                    var words = lowerSkill.Split(' ', StringSplitOptions.RemoveEmptyEntries);

//                    if (words.Any(word => word.Contains(query)) && !results.Contains(skill))
//                    {
//                        results.Add(skill);
//                        if (results.Count >= maxResults)
//                            break;
//                    }
//                }
//            }

//            return Ok(results);
//        }

//        // 2. API to Return Skills by Category
//        [HttpGet("GetSkillsByCategory")]
//        public async Task<IActionResult> GetSkillsByCategory([FromQuery] string category, [FromQuery] bool sort = true)
//        {
//            if (string.IsNullOrWhiteSpace(category))
//                return BadRequest("Category is required.");

//            // Normalize both sides to lowercase for case-insensitive comparison
//            var normalizedCategory = category.Trim().ToLower();

//            var query = _context.Skills
//                .Where(s => s.Category.ToLower() == normalizedCategory);

//            if (sort)
//                query = query.OrderBy(s => s.Name);

//            var skills = await query.ToListAsync();
//            return Ok(skills);
//        }

//        [HttpGet("GetSkillsGroupedByCategory")]
//        public async Task<IActionResult> GetSkillsGroupedByCategory()
//        {
//            var skills = await _context.Skills
//                .OrderBy(s => s.Category)
//                .ThenBy(s => s.Name)
//                .ToListAsync();

//            var grouped = skills
//                .GroupBy(s => s.Category)
//                .ToDictionary(
//                    g => g.Key,
//                    g => g.Select(skill => new {
//                        skill.Id,
//                        skill.Name,
//                        skill.CreatedAt
//                    }).ToList()
//                );

//            return Ok(grouped);
//        }

//        // -------------------------
//        // New endpoint requested:
//        // GET /api/utils/GetSimilarUsers?userId={guid}&county=Nairobi
//        // - userId (optional) - if not provided will attempt to read from claims
//        // - county (optional)
//        // Returns logged-in user details and exactly 3 similar users (or fallback random users)
//        // -------------------------
//        [HttpGet("GetSimilarUsers")]
//        public async Task<IActionResult> GetSimilarUsers([FromQuery] Guid? userId = null, [FromQuery] string? county = null)
//        {
//            // Resolve user id: query -> claims
//            string? claimUserId = null;
//            if (userId == null)
//            {
//                claimUserId = User?.FindFirst("userId")?.Value ?? User?.FindFirst(ClaimTypes.NameIdentifier)?.Value;
//                if (!string.IsNullOrWhiteSpace(claimUserId) && Guid.TryParse(claimUserId, out var parsed))
//                    userId = parsed;
//            }

//            if (userId == null || userId == Guid.Empty)
//                return BadRequest(new { message = "User id is required either via query or authenticated claim 'userId'." });

//            // Load the logged-in user (only required fields)
//            var currentUser = await _context.SignUps
//                .Where(u => u.Id == userId.Value)
//                .Select(u => new
//                {
//                    u.Id,
//                    u.FullName,
//                    u.Email,
//                    u.Skills,
//                    u.CityOrTown,
//                    u.LocalityOrArea,
//                    u.Country
//                })
//                .FirstOrDefaultAsync();

//            if (currentUser == null)
//                return NotFound(new { message = "User not found." });

//            // Normalize user's skills for case-insensitive matching
//            var userSkills = (currentUser.Skills ?? new List<string>())
//                .Where(s => !string.IsNullOrWhiteSpace(s))
//                .Select(s => s.Trim().ToLowerInvariant())
//                .Distinct()
//                .ToList();

//            string? normalizedCounty = string.IsNullOrWhiteSpace(county) ? null : county.Trim().ToLowerInvariant();

//            // Load other users with minimal fields to perform in-memory matching.
//            // If dataset grows, replace with normalized join table / server-side JSON queries.
//            var others = await _context.SignUps
//                .Where(u => u.Id != currentUser.Id)
//                .Select(u => new
//                {
//                    u.Id,
//                    u.FullName,
//                    u.Email,
//                    u.Skills,
//                    u.CityOrTown,
//                    u.LocalityOrArea,
//                    u.Country
//                })
//                .ToListAsync();

//            // Helper to check county match if provided
//            bool CountyMatches(dynamic u)
//            {
//                if (normalizedCounty == null) return true;
//                var city = (u.CityOrTown as string)?.Trim().ToLowerInvariant();
//                var locality = (u.LocalityOrArea as string)?.Trim().ToLowerInvariant();
//                return (!string.IsNullOrWhiteSpace(city) && city.Contains(normalizedCounty))
//                    || (!string.IsNullOrWhiteSpace(locality) && locality.Contains(normalizedCounty));
//            }

//            // Find users that share at least one skill
//            var matched = new List<dynamic>();
//            if (userSkills.Count > 0)
//            {
//                foreach (var u in others)
//                {
//                    if (!CountyMatches(u))
//                        continue;

//                    var candidateSkills = (u.Skills ?? new List<string>())
//                        .Where(s => !string.IsNullOrWhiteSpace(s))
//                        .Select(s => new { Raw = s, Lower = s.Trim().ToLowerInvariant() })
//                        .ToList();

//                    var overlap = candidateSkills.FirstOrDefault(cs => userSkills.Contains(cs.Lower));
//                    if (overlap != null)
//                    {
//                        matched.Add(new
//                        {
//                            userId = u.Id.ToString(),
//                            fullName = u.FullName,
//                            email = u.Email,
//                            skill = overlap.Raw,
//                            county = u.CityOrTown ?? string.Empty,
//                            country = u.Country ?? string.Empty
//                        });
//                    }
//                }
//            }

//            // If no matched users, fallback to 3 random users (still respecting county filter if provided)
//            IEnumerable<dynamic> selection;
//            if (matched.Count > 0)
//            {
//                selection = matched
//                    .OrderBy(_ => Guid.NewGuid())
//                    .Take(3)
//                    .ToList();
//            }
//            else
//            {
//                var fallback = others
//                    .Where(u => CountyMatches(u))
//                    .Select(u => new
//                    {
//                        userId = u.Id.ToString(),
//                        fullName = u.FullName,
//                        email = u.Email,
//                        // best-effort: include first skill if present
//                        skill = (u.Skills != null && u.Skills.Count > 0) ? u.Skills.First() : string.Empty,
//                        county = u.CityOrTown ?? string.Empty,
//                        country = u.Country ?? string.Empty
//                    })
//                    .OrderBy(_ => Guid.NewGuid())
//                    .Take(3)
//                    .ToList();

//                selection = fallback;
//            }

//            // Build the response user object
//            var responseUser = new
//            {
//                userId = currentUser.Id.ToString(),
//                fullName = currentUser.FullName,
//                email = currentUser.Email,
//                skills = currentUser.Skills ?? new List<string>(),
//                county = currentUser.CityOrTown ?? string.Empty,
//                country = currentUser.Country ?? string.Empty
//            };

//            // Log this lookup for analytics
//            try
//            {
//                var ip = HttpContext.Connection.RemoteIpAddress?.ToString();
//                var ua = Request.Headers["User-Agent"].FirstOrDefault();
//                var log = new NipeNikupe.Models.SkillSearchLog
//                {
//                    Skill = userSkills.Count == 0 ? string.Empty : string.Join(",", userSkills),
//                    County = county,
//                    UserId = currentUser.Id.ToString(),
//                    IpAddress = ip,
//                    UserAgent = ua,
//                    ResultsCount = selection?.Count() ?? 0,
//                    SearchTimeUtc = DateTime.UtcNow
//                };
//                _context.SkillSearchLogs.Add(log);
//                await _context.SaveChangesAsync();
//            }
//            catch
//            {
//                // Do not fail the request on logging errors
//            }

//            return Ok(new
//            {
//                user = responseUser,
//                similarUsers = selection
//            });
//        }

//        // -------------------------
//        // New endpoint requested:
//        // GET /api/skills/search?skill=plumbing&county=Nairobi
//        // GET SearchUsersBySkillAndCounty?skill=plumbing&county=Nairobi
//        // - skill (required)
//        // - county (optional)
//        // Returns matching users (profile & contact) who offer the skill, optionally filtered by county.
//        // -------------------------

//        [HttpGet("SearchUsersBySkillAndCounty")]
//        public async Task<IActionResult> SearchUsersBySkillAndCounty([FromQuery] string skill, [FromQuery] string? county = null)
//        {
//            if (string.IsNullOrWhiteSpace(skill))
//                return BadRequest("Query parameter 'skill' is required.");

//            var search = skill.Trim().ToLowerInvariant();
//            string? normalizedCounty = string.IsNullOrWhiteSpace(county) ? null : county.Trim().ToLowerInvariant();

//            // Load users. If you expect many users, replace with a paged query or normalized UserSkill join table.
//            var users = await _context.SignUps.ToListAsync();

//            var results = new List<object>();

//            foreach (var user in users)
//            {
//                // Ensure user has skills
//                if (user.Skills == null || user.Skills.Count == 0)
//                    continue;

//                // Find matching skills for this user (case-insensitive, partial match)
//                var matchedSkill = user.Skills
//                    .Where(s => !string.IsNullOrWhiteSpace(s))
//                    .Select(s => new { Raw = s, Lower = s.Trim().ToLowerInvariant() })
//                    .FirstOrDefault(s => s.Lower.Contains(search));

//                if (matchedSkill == null)
//                    continue;

//                // If county filter provided, try to match against user's CityOrTown or LocalityOrArea (sign-up model does not have a 'County' field)
//                if (normalizedCounty != null)
//                {
//                    var city = user.CityOrTown?.Trim().ToLowerInvariant();
//                    var locality = user.LocalityOrArea?.Trim().ToLowerInvariant();

//                    // Match if county equals or is contained in either city or locality (helps with "Nairobi" and "Westlands" cases)
//                    var countyMatches =
//                        (!string.IsNullOrWhiteSpace(city) && city.Contains(normalizedCounty)) ||
//                        (!string.IsNullOrWhiteSpace(locality) && locality.Contains(normalizedCounty));

//                    if (!countyMatches)
//                        continue;
//                }

//                // Build result item
//                results.Add(new
//                {
//                    userId = user.Id.ToString(),
//                    fullName = user.FullName,
//                    skill = matchedSkill.Raw,
//                    county = user.CityOrTown ?? string.Empty,
//                    country = user.Country ?? string.Empty,
//                    contact = user.Email
//                });
//            }

//            // ********** Log this search for analytics **********
//            try
//            {
//                //var userIdClaim = User?.FindFirst("userId")?.Value; // may be null for anonymous
//                var userIdClaim = User.FindFirst("userId")?.Value;
//                var ip = HttpContext.Connection.RemoteIpAddress?.ToString();
//                var ua = Request.Headers["User-Agent"].FirstOrDefault();

//                var log = new NipeNikupe.Models.SkillSearchLog
//                {
//                    Skill = skill.Trim(),
//                    County = county,
//                    UserId = userIdClaim,
//                    IpAddress = ip,
//                    UserAgent = ua,
//                    ResultsCount = results.Count,
//                    SearchTimeUtc = DateTime.UtcNow
//                };
//                _context.SkillSearchLogs.Add(log);
//                // await to ensure log persisted; consider fire-and-forget in high-throughput scenarios
//                await _context.SaveChangesAsync();
//            }
//            catch
//            {
//                // logging must not break the API — swallow errors or write to fallback logger
//            }

//            return Ok(results);
//        }

//        //[HttpGet("SearchUsersBySkillAndCounty")]
//        //public async Task<IActionResult> SearchUsersBySkillAndCounty([FromQuery] string skill, [FromQuery] string? county = null)
//        //{
//        //    if (string.IsNullOrWhiteSpace(skill))
//        //        return BadRequest("Query parameter 'skill' is required.");

//        //    var search = skill.Trim().ToLowerInvariant();
//        //    string? normalizedCounty = string.IsNullOrWhiteSpace(county) ? null : county.Trim().ToLowerInvariant();

//        //    // Load users. If you expect many users, replace with a paged query or normalized UserSkill join table.
//        //    var users = await _context.SignUps.ToListAsync();

//        //    var results = new List<object>();

//        //    foreach (var user in users)
//        //    {
//        //        // Ensure user has skills
//        //        if (user.Skills == null || user.Skills.Count == 0)
//        //            continue;

//        //        // Find matching skills for this user (case-insensitive, partial match)
//        //        var matchedSkill = user.Skills
//        //            .Where(s => !string.IsNullOrWhiteSpace(s))
//        //            .Select(s => new { Raw = s, Lower = s.Trim().ToLowerInvariant() })
//        //            .FirstOrDefault(s => s.Lower.Contains(search));

//        //        if (matchedSkill == null)
//        //            continue;

//        //        // If county filter provided, try to match against user's CityOrTown or LocalityOrArea (sign-up model does not have a 'County' field)
//        //        if (normalizedCounty != null)
//        //        {
//        //            var city = user.CityOrTown?.Trim().ToLowerInvariant();
//        //            var locality = user.LocalityOrArea?.Trim().ToLowerInvariant();

//        //            // Match if county equals or is contained in either city or locality (helps with "Nairobi" and "Westlands" cases)
//        //            var countyMatches =
//        //                (!string.IsNullOrWhiteSpace(city) && city.Contains(normalizedCounty)) ||
//        //                (!string.IsNullOrWhiteSpace(locality) && locality.Contains(normalizedCounty));

//        //            if (!countyMatches)
//        //                continue;
//        //        }

//        //        // Build result item
//        //        results.Add(new
//        //        {
//        //            userId = user.Id.ToString(),
//        //            fullName = user.FullName,
//        //            skill = matchedSkill.Raw,
//        //            county = user.CityOrTown ?? string.Empty,
//        //            country = user.Country ?? string.Empty,
//        //            contact = user.Email
//        //        });
//        //    }

//        //    // ********** Log this search for analytics **********
//        //    try
//        //    {
//        //        // Attempt to resolve user id from claims first, then fallback to query string "userId"
//        //        var userIdClaim = GetUserIdFromClaims() ?? Request.Query["userId"].FirstOrDefault();
//        //        var ip = HttpContext.Connection.RemoteIpAddress?.ToString();
//        //        var ua = Request.Headers["User-Agent"].FirstOrDefault();

//        //        var log = new NipeNikupe.Models.SkillSearchLog
//        //        {
//        //            Skill = skill.Trim(),
//        //            County = county,
//        //            UserId = userIdClaim,
//        //            IpAddress = ip,
//        //            UserAgent = ua,
//        //            ResultsCount = results.Count,
//        //            SearchTimeUtc = DateTime.UtcNow
//        //        };
//        //        _context.SkillSearchLogs.Add(log);
//        //        // await to ensure log persisted; consider fire-and-forget in high-throughput scenarios
//        //        await _context.SaveChangesAsync();
//        //    }
//        //    catch
//        //    {
//        //        // logging must not break the API — swallow errors or write to fallback logger
//        //    }

//        //    return Ok(results);
//        //}

//        //// Helper: try common claim names for user id
//        //private string? GetUserIdFromClaims()
//        //{
//        //    if (User == null) return null;

//        //    var candidateClaimTypes = new[]
//        //    {
//        //        "userId",
//        //        ClaimTypes.NameIdentifier,
//        //        "sub",
//        //        "id",
//        //        "nameid"
//        //    };

//        //    foreach (var ct in candidateClaimTypes)
//        //    {
//        //        var c = User.FindFirst(ct);
//        //        if (c != null && !string.IsNullOrWhiteSpace(c.Value))
//        //            return c.Value;
//        //    }

//        //    // no claim found
//        //    return null;
//        //}
//}
//        }



//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using NipeNikupe.Data;
//using System.Globalization;
//using System.Security.Claims;
//using System.Linq;
//using Microsoft.AspNetCore.Authorization;

//namespace NipeNikupe.Controllers
//{
//    [ApiController]
//    [Route("api/utils")]
//    public class UtilsController : ControllerBase
//    {
//        private readonly AppDbContext _context;
//        private readonly ILogger<UtilsController> _logger;

//        public UtilsController(AppDbContext context, ILogger<UtilsController> logger)
//        {
//            _context = context;
//            _logger = logger;
//        }

//        [HttpGet("GetAllCounties")]
//        public async Task<IActionResult> GetAllCounties()
//        {
//            var counties = await _context.Counties.OrderBy(c => c.Id).ToListAsync();
//            return Ok(counties);
//        }

//        [HttpGet("GetCountyById/{id}")]
//        public async Task<IActionResult> GetCountyById(int id)
//        {
//            var county = await _context.Counties.FindAsync(id);
//            if (county == null)
//                return NotFound(new { message = "County not found." });
//            return Ok(county);
//        }

//        // 1. Skill Search for Autocomplete
//        [HttpGet("SearchSkills")]
//        public async Task<IActionResult> SearchSkills([FromQuery] string query, [FromQuery] int maxResults = 10)
//        {
//            if (string.IsNullOrWhiteSpace(query))
//                return BadRequest("Query is required.");

//            query = query.Trim().ToLower(CultureInfo.InvariantCulture);

//            // Get all skill names sorted alphabetically
//            var skills = await _context.Skills
//                .OrderBy(s => s.Name)
//                .Select(s => s.Name)
//                .ToListAsync();

//            // Binary search isn't ideal for substring matching (it's best for prefix searches),
//            // but we'll combine prefix efficiency with substring fallback.

//            var results = new List<string>();

//            // 1️⃣ Try to find prefix matches first (efficient)
//            foreach (var skill in skills)
//            {
//                var lowerSkill = skill.ToLower(CultureInfo.InvariantCulture);
//                if (lowerSkill.StartsWith(query))
//                {
//                    results.Add(skill);
//                    if (results.Count >= maxResults)
//                        return Ok(results);
//                }
//            }

//            // 2️⃣ If not enough results, also find matches where any *word* contains the query
//            if (results.Count < maxResults)
//            {
//                foreach (var skill in skills)
//                {
//                    var lowerSkill = skill.ToLower(CultureInfo.InvariantCulture);
//                    var words = lowerSkill.Split(' ', StringSplitOptions.RemoveEmptyEntries);

//                    if (words.Any(word => word.Contains(query)) && !results.Contains(skill))
//                    {
//                        results.Add(skill);
//                        if (results.Count >= maxResults)
//                            break;
//                    }
//                }
//            }

//            return Ok(results);
//        }

//        // 2. API to Return Skills by Category
//        [HttpGet("GetSkillsByCategory")]
//        public async Task<IActionResult> GetSkillsByCategory([FromQuery] string category, [FromQuery] bool sort = true)
//        {
//            if (string.IsNullOrWhiteSpace(category))
//                return BadRequest("Category is required.");

//            // Normalize both sides to lowercase for case-insensitive comparison
//            var normalizedCategory = category.Trim().ToLower();

//            var query = _context.Skills
//                .Where(s => s.Category.ToLower() == normalizedCategory);

//            if (sort)
//                query = query.OrderBy(s => s.Name);

//            var skills = await query.ToListAsync();
//            return Ok(skills);
//        }

//        [HttpGet("GetSkillsGroupedByCategory")]
//        public async Task<IActionResult> GetSkillsGroupedByCategory()
//        {
//            var skills = await _context.Skills
//                .OrderBy(s => s.Category)
//                .ThenBy(s => s.Name)
//                .ToListAsync();

//            var grouped = skills
//                .GroupBy(s => s.Category)
//                .ToDictionary(
//                    g => g.Key,
//                    g => g.Select(skill => new {
//                        skill.Id,
//                        skill.Name,
//                        skill.CreatedAt
//                    }).ToList()
//                );

//            return Ok(grouped);
//        }

//        // -------------------------
//        // New endpoint requested:
//        // GET /api/utils/GetSimilarUsers?userId={guid}&county=Nairobi
//        // - userId (optional) - if not provided will attempt to read from claims
//        // - county (optional)
//        // Returns logged-in user details and exactly 3 similar users (or fallback random users)
//        // -------------------------
//        [HttpGet("GetSimilarUsers")]
//        public async Task<IActionResult> GetSimilarUsers([FromQuery] Guid? userId = null, [FromQuery] string? county = null)
//        {
//            // Resolve user id: query -> claims
//            string? claimUserId = null;
//            if (userId == null)
//            {
//                claimUserId = User?.FindFirst("userId")?.Value ?? User?.FindFirst(ClaimTypes.NameIdentifier)?.Value;
//                if (!string.IsNullOrWhiteSpace(claimUserId) && Guid.TryParse(claimUserId, out var parsed))
//                    userId = parsed;
//            }

//            if (userId == null || userId == Guid.Empty)
//                return BadRequest(new { message = "User id is required either via query or authenticated claim 'userId'." });

//            // Load the logged-in user (only required fields)
//            var currentUser = await _context.SignUps
//                .Where(u => u.Id == userId.Value)
//                .Select(u => new
//                {
//                    u.Id,
//                    u.FullName,
//                    u.Email,
//                    u.Skills,
//                    u.CityOrTown,
//                    u.LocalityOrArea,
//                    u.Country
//                })
//                .FirstOrDefaultAsync();

//            if (currentUser == null)
//                return NotFound(new { message = "User not found." });

//            // Normalize user's skills for case-insensitive matching
//            var userSkills = (currentUser.Skills ?? new List<string>())
//                .Where(s => !string.IsNullOrWhiteSpace(s))
//                .Select(s => s.Trim().ToLowerInvariant())
//                .Distinct()
//                .ToList();

//            string? normalizedCounty = string.IsNullOrWhiteSpace(county) ? null : county.Trim().ToLowerInvariant();

//            // Load other users with minimal fields to perform in-memory matching.
//            // If dataset grows, replace with normalized join table / server-side JSON queries.
//            var others = await _context.SignUps
//                .Where(u => u.Id != currentUser.Id)
//                .Select(u => new
//                {
//                    u.Id,
//                    u.FullName,
//                    u.Email,
//                    u.Skills,
//                    u.CityOrTown,
//                    u.LocalityOrArea,
//                    u.Country
//                })
//                .ToListAsync();

//            // Helper to check county match if provided
//            bool CountyMatches(dynamic u)
//            {
//                if (normalizedCounty == null) return true;
//                var city = (u.CityOrTown as string)?.Trim().ToLowerInvariant();
//                var locality = (u.LocalityOrArea as string)?.Trim().ToLowerInvariant();
//                return (!string.IsNullOrWhiteSpace(city) && city.Contains(normalizedCounty))
//                    || (!string.IsNullOrWhiteSpace(locality) && locality.Contains(normalizedCounty));
//            }

//            // Find users that share at least one skill
//            var matched = new List<dynamic>();
//            if (userSkills.Count > 0)
//            {
//                foreach (var u in others)
//                {
//                    if (!CountyMatches(u))
//                        continue;

//                    var candidateSkills = (u.Skills ?? new List<string>())
//                        .Where(s => !string.IsNullOrWhiteSpace(s))
//                        .Select(s => new { Raw = s, Lower = s.Trim().ToLowerInvariant() })
//                        .ToList();

//                    var overlap = candidateSkills.FirstOrDefault(cs => userSkills.Contains(cs.Lower));
//                    if (overlap != null)
//                    {
//                        matched.Add(new
//                        {
//                            userId = u.Id.ToString(),
//                            fullName = u.FullName,
//                            email = u.Email,
//                            skill = overlap.Raw,
//                            county = u.CityOrTown ?? string.Empty,
//                            country = u.Country ?? string.Empty
//                        });
//                    }
//                }
//            }

//            // If no matched users, fallback to 3 random users (still respecting county filter if provided)
//            IEnumerable<dynamic> selection;
//            if (matched.Count > 0)
//            {
//                selection = matched
//                    .OrderBy(_ => Guid.NewGuid())
//                    .Take(3)
//                    .ToList();
//            }
//            else
//            {
//                var fallback = others
//                    .Where(u => CountyMatches(u))
//                    .Select(u => new
//                    {
//                        userId = u.Id.ToString(),
//                        fullName = u.FullName,
//                        email = u.Email,
//                        // best-effort: include first skill if present
//                        skill = (u.Skills != null && u.Skills.Count > 0) ? u.Skills.First() : string.Empty,
//                        county = u.CityOrTown ?? string.Empty,
//                        country = u.Country ?? string.Empty
//                    })
//                    .OrderBy(_ => Guid.NewGuid())
//                    .Take(3)
//                    .ToList();

//                selection = fallback;
//            }

//            // Build the response user object
//            var responseUser = new
//            {
//                userId = currentUser.Id.ToString(),
//                fullName = currentUser.FullName,
//                email = currentUser.Email,
//                skills = currentUser.Skills ?? new List<string>(),
//                county = currentUser.CityOrTown ?? string.Empty,
//                country = currentUser.Country ?? string.Empty
//            };

//            // Log this lookup for analytics
//            try
//            {
//                var ip = HttpContext.Connection.RemoteIpAddress?.ToString();
//                var ua = Request.Headers["User-Agent"].FirstOrDefault();
//                var log = new NipeNikupe.Models.SkillSearchLog
//                {
//                    Skill = userSkills.Count == 0 ? string.Empty : string.Join(",", userSkills),
//                    County = county,
//                    UserId = currentUser.Id.ToString(),
//                    IpAddress = ip,
//                    UserAgent = ua,
//                    ResultsCount = selection?.Count() ?? 0,
//                    SearchTimeUtc = DateTime.UtcNow
//                };
//                _context.SkillSearchLogs.Add(log);
//                await _context.SaveChangesAsync();
//            }
//            catch
//            {
//                // Do not fail the request on logging errors
//            }

//            return Ok(new
//            {
//                user = responseUser,
//                similarUsers = selection
//            });
//        }

//        // -------------------------
//        // New endpoint requested:
//        // GET /api/utils/SearchUsersBySkillAndCounty?skill=plumbing&county=Nairobi
//        // - skill (required)
//        // - county (optional)
//        // Returns matching users (profile & contact) who offer the skill, optionally filtered by county.
//        // 
//        // ⚠️ REQUIRES AUTHENTICATION to log the searching user's ID
//        // -------------------------
//        [Authorize]  // ⬅️ THIS IS THE KEY FIX
//        [HttpGet("SearchUsersBySkillAndCounty")]
//        public async Task<IActionResult> SearchUsersBySkillAndCounty([FromQuery] string skill, [FromQuery] string? county = null)
//        {
//            if (string.IsNullOrWhiteSpace(skill))
//                return BadRequest("Query parameter 'skill' is required.");

//            var search = skill.Trim().ToLowerInvariant();
//            string? normalizedCounty = string.IsNullOrWhiteSpace(county) ? null : county.Trim().ToLowerInvariant();

//            // Load users. If you expect many users, replace with a paged query or normalized UserSkill join table.
//            var users = await _context.SignUps.ToListAsync();

//            var results = new List<object>();

//            foreach (var user in users)
//            {
//                // Ensure user has skills
//                if (user.Skills == null || user.Skills.Count == 0)
//                    continue;

//                // Find matching skills for this user (case-insensitive, partial match)
//                var matchedSkill = user.Skills
//                    .Where(s => !string.IsNullOrWhiteSpace(s))
//                    .Select(s => new { Raw = s, Lower = s.Trim().ToLowerInvariant() })
//                    .FirstOrDefault(s => s.Lower.Contains(search));

//                if (matchedSkill == null)
//                    continue;

//                // If county filter provided, try to match against user's CityOrTown or LocalityOrArea (sign-up model does not have a 'County' field)
//                if (normalizedCounty != null)
//                {
//                    var city = user.CityOrTown?.Trim().ToLowerInvariant();
//                    var locality = user.LocalityOrArea?.Trim().ToLowerInvariant();

//                    // Match if county equals or is contained in either city or locality (helps with "Nairobi" and "Westlands" cases)
//                    var countyMatches =
//                        (!string.IsNullOrWhiteSpace(city) && city.Contains(normalizedCounty)) ||
//                        (!string.IsNullOrWhiteSpace(locality) && locality.Contains(normalizedCounty));

//                    if (!countyMatches)
//                        continue;
//                }

//                // Build result item
//                results.Add(new
//                {
//                    userId = user.Id.ToString(),
//                    fullName = user.FullName,
//                    skill = matchedSkill.Raw,
//                    county = user.CityOrTown ?? string.Empty,
//                    country = user.Country ?? string.Empty,
//                    contact = user.Email
//                });
//            }

//            // ********** Log this search for analytics **********
//            try
//            {
//                // Attempt to resolve user id from claims with detailed debugging
//                var userIdClaim = GetUserIdFromClaims();

//                // 🔍 DEBUG: Log all claims for troubleshooting
//                _logger.LogInformation("=== SearchUsersBySkillAndCounty Claims Debug ===");
//                _logger.LogInformation($"User.Identity.IsAuthenticated: {User?.Identity?.IsAuthenticated}");
//                _logger.LogInformation($"User.Identity.Name: {User?.Identity?.Name}");
//                _logger.LogInformation($"Found userId claim: {userIdClaim ?? "NULL"}");

//                if (User?.Claims != null)
//                {
//                    foreach (var claim in User.Claims)
//                    {
//                        _logger.LogInformation($"Claim: {claim.Type} = {claim.Value}");
//                    }
//                }

//                // If no userId found in claims, check query string as fallback
//                if (string.IsNullOrWhiteSpace(userIdClaim))
//                {
//                    userIdClaim = Request.Query["userId"].FirstOrDefault();
//                    _logger.LogInformation($"Fallback to query string userId: {userIdClaim ?? "NULL"}");
//                }

//                var ip = HttpContext.Connection.RemoteIpAddress?.ToString();
//                var ua = Request.Headers["User-Agent"].FirstOrDefault();

//                var log = new NipeNikupe.Models.SkillSearchLog
//                {
//                    Skill = skill.Trim(),
//                    County = county,
//                    UserId = userIdClaim,  // Will be null if not authenticated or no userId claim
//                    IpAddress = ip,
//                    UserAgent = ua,
//                    ResultsCount = results.Count,
//                    SearchTimeUtc = DateTime.UtcNow
//                };

//                _context.SkillSearchLogs.Add(log);
//                await _context.SaveChangesAsync();

//                _logger.LogInformation($"✅ Successfully logged search with UserId: {userIdClaim ?? "NULL"}");
//            }
//            catch (Exception ex)
//            {
//                // Log the exception for debugging
//                _logger.LogError(ex, "❌ Failed to log search analytics");
//            }

//            return Ok(results);
//        }

//        // Helper: try common claim names for user id
//        private string? GetUserIdFromClaims()
//        {
//            if (User == null || !User.Identity.IsAuthenticated)
//            {
//                _logger.LogWarning("GetUserIdFromClaims: User is null or not authenticated");
//                return null;
//            }

//            var candidateClaimTypes = new[]
//            {
//                "userId",           // Your custom claim
//                ClaimTypes.NameIdentifier,  // Standard claim
//                "sub",              // JWT standard
//                "id",
//                "nameid"
//            };

//            foreach (var ct in candidateClaimTypes)
//            {
//                var c = User.FindFirst(ct);
//                if (c != null && !string.IsNullOrWhiteSpace(c.Value))
//                {
//                    _logger.LogInformation($"Found userId in claim type '{ct}': {c.Value}");
//                    return c.Value;
//                }
//            }

//            _logger.LogWarning("No userId claim found in any candidate claim types");
//            return null;
//        }

//    }
//}


using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NipeNikupe.Data;
using System.Globalization;
using System.Security.Claims;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace NipeNikupe.Controllers
{
    [ApiController]
    [Route("api/utils")]
    public class UtilsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ILogger<UtilsController> _logger;

        public UtilsController(AppDbContext context, ILogger<UtilsController> logger)
        {
            _context = context;
            _logger = logger;
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

            // Binary search isn't ideal for substring matching (it's best for prefix searches),
            // but we'll combine prefix efficiency with substring fallback.

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
        // GET /api/utils/GetSimilarUsers?userId={guid}&county=Nairobi
        // - userId (optional) - if not provided will attempt to read from claims
        // - county (optional)
        // Returns logged-in user details and exactly 3 similar users (or fallback random users)
        // -------------------------
        [HttpGet("GetSimilarUsers")]
        public async Task<IActionResult> GetSimilarUsers([FromQuery] Guid? userId = null, [FromQuery] string? county = null)
        {
            // Resolve user id: query -> claims
            string? claimUserId = null;
            if (userId == null)
            {
                claimUserId = User?.FindFirst("userId")?.Value ?? User?.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                if (!string.IsNullOrWhiteSpace(claimUserId) && Guid.TryParse(claimUserId, out var parsed))
                    userId = parsed;
            }

            if (userId == null || userId == Guid.Empty)
                return BadRequest(new { message = "User id is required either via query or authenticated claim 'userId'." });

            // Load the logged-in user (only required fields)
            var currentUser = await _context.SignUps
                .Where(u => u.Id == userId.Value)
                .Select(u => new
                {
                    u.Id,
                    u.FullName,
                    u.Email,
                    u.Skills,
                    u.CityOrTown,
                    u.LocalityOrArea,
                    u.Country
                })
                .FirstOrDefaultAsync();

            if (currentUser == null)
                return NotFound(new { message = "User not found." });

            // Normalize user's skills for case-insensitive matching
            var userSkills = (currentUser.Skills ?? new List<string>())
                .Where(s => !string.IsNullOrWhiteSpace(s))
                .Select(s => s.Trim().ToLowerInvariant())
                .Distinct()
                .ToList();

            string? normalizedCounty = string.IsNullOrWhiteSpace(county) ? null : county.Trim().ToLowerInvariant();

            // Load other users with minimal fields to perform in-memory matching.
            // If dataset grows, replace with normalized join table / server-side JSON queries.
            var others = await _context.SignUps
                .Where(u => u.Id != currentUser.Id)
                .Select(u => new
                {
                    u.Id,
                    u.FullName,
                    u.Email,
                    u.Skills,
                    u.CityOrTown,
                    u.LocalityOrArea,
                    u.Country
                })
                .ToListAsync();

            // Helper to check county match if provided
            bool CountyMatches(dynamic u)
            {
                if (normalizedCounty == null) return true;
                var city = (u.CityOrTown as string)?.Trim().ToLowerInvariant();
                var locality = (u.LocalityOrArea as string)?.Trim().ToLowerInvariant();
                return (!string.IsNullOrWhiteSpace(city) && city.Contains(normalizedCounty))
                    || (!string.IsNullOrWhiteSpace(locality) && locality.Contains(normalizedCounty));
            }

            // Find users that share at least one skill
            var matched = new List<dynamic>();
            if (userSkills.Count > 0)
            {
                foreach (var u in others)
                {
                    if (!CountyMatches(u))
                        continue;

                    var candidateSkills = (u.Skills ?? new List<string>())
                        .Where(s => !string.IsNullOrWhiteSpace(s))
                        .Select(s => new { Raw = s, Lower = s.Trim().ToLowerInvariant() })
                        .ToList();

                    var overlap = candidateSkills.FirstOrDefault(cs => userSkills.Contains(cs.Lower));
                    if (overlap != null)
                    {
                        matched.Add(new
                        {
                            userId = u.Id.ToString(),
                            fullName = u.FullName,
                            email = u.Email,
                            skill = overlap.Raw,
                            county = u.CityOrTown ?? string.Empty,
                            country = u.Country ?? string.Empty
                        });
                    }
                }
            }

            // If no matched users, fallback to 3 random users (still respecting county filter if provided)
            IEnumerable<dynamic> selection;
            if (matched.Count > 0)
            {
                selection = matched
                    .OrderBy(_ => Guid.NewGuid())
                    .Take(3)
                    .ToList();
            }
            else
            {
                var fallback = others
                    .Where(u => CountyMatches(u))
                    .Select(u => new
                    {
                        userId = u.Id.ToString(),
                        fullName = u.FullName,
                        email = u.Email,
                        // best-effort: include first skill if present
                        skill = (u.Skills != null && u.Skills.Count > 0) ? u.Skills.First() : string.Empty,
                        county = u.CityOrTown ?? string.Empty,
                        country = u.Country ?? string.Empty
                    })
                    .OrderBy(_ => Guid.NewGuid())
                    .Take(3)
                    .ToList();

                selection = fallback;
            }

            // Build the response user object
            var responseUser = new
            {
                userId = currentUser.Id.ToString(),
                fullName = currentUser.FullName,
                email = currentUser.Email,
                skills = currentUser.Skills ?? new List<string>(),
                county = currentUser.CityOrTown ?? string.Empty,
                country = currentUser.Country ?? string.Empty
            };

            // Log this lookup for analytics
            try
            {
                var ip = HttpContext.Connection.RemoteIpAddress?.ToString();
                var ua = Request.Headers["User-Agent"].FirstOrDefault();
                var log = new NipeNikupe.Models.SkillSearchLog
                {
                    Skill = userSkills.Count == 0 ? string.Empty : string.Join(",", userSkills),
                    County = county,
                    UserId = currentUser.Id.ToString(),
                    IpAddress = ip,
                    UserAgent = ua,
                    ResultsCount = selection?.Count() ?? 0,
                    SearchTimeUtc = DateTime.UtcNow
                };
                _context.SkillSearchLogs.Add(log);
                await _context.SaveChangesAsync();
            }
            catch
            {
                // Do not fail the request on logging errors
            }

            return Ok(new
            {
                user = responseUser,
                similarUsers = selection
            });
        }

        // -------------------------
        // New endpoint requested:
        // GET /api/utils/SearchUsersBySkillAndCounty?skill=plumbing&county=Nairobi
        // - skill (required)
        // - county (optional)
        // Returns matching users (profile & contact) who offer the skill, optionally filtered by county.
        // 
        // ⚠️ REQUIRES AUTHENTICATION to log the searching user's ID
        // -------------------------
        [Authorize]  // ⬅️ THIS IS THE KEY FIX
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
                    contact = user.Email,
                    skills = user.Skills  // Include full skills list
                });
            }

            // ********** Log this search for analytics **********
            try
            {
                // Attempt to resolve user id from claims with detailed debugging
                var userIdClaim = GetUserIdFromClaims();

                // 🔍 DEBUG: Log all claims for troubleshooting
                _logger.LogInformation("=== SearchUsersBySkillAndCounty Claims Debug ===");
                _logger.LogInformation($"User.Identity.IsAuthenticated: {User?.Identity?.IsAuthenticated}");
                _logger.LogInformation($"User.Identity.Name: {User?.Identity?.Name}");
                _logger.LogInformation($"Found userId claim: {userIdClaim ?? "NULL"}");

                if (User?.Claims != null)
                {
                    foreach (var claim in User.Claims)
                    {
                        _logger.LogInformation($"Claim: {claim.Type} = {claim.Value}");
                    }
                }

                // If no userId found in claims, check query string as fallback
                if (string.IsNullOrWhiteSpace(userIdClaim))
                {
                    userIdClaim = Request.Query["userId"].FirstOrDefault();
                    _logger.LogInformation($"Fallback to query string userId: {userIdClaim ?? "NULL"}");
                }

                var ip = HttpContext.Connection.RemoteIpAddress?.ToString();
                var ua = Request.Headers["User-Agent"].FirstOrDefault();

                var log = new NipeNikupe.Models.SkillSearchLog
                {
                    Skill = skill.Trim(),
                    County = county,
                    UserId = userIdClaim,  // Will be null if not authenticated or no userId claim
                    IpAddress = ip,
                    UserAgent = ua,
                    ResultsCount = results.Count,
                    SearchTimeUtc = DateTime.UtcNow
                };

                _context.SkillSearchLogs.Add(log);
                await _context.SaveChangesAsync();

                _logger.LogInformation($"✅ Successfully logged search with UserId: {userIdClaim ?? "NULL"}");
            }
            catch (Exception ex)
            {
                // Log the exception for debugging
                _logger.LogError(ex, "❌ Failed to log search analytics");
            }

            return Ok(results);
        }

        // -------------------------
        // NEW ENDPOINT: Get Recent Search History (STACK - LIFO with UNIQUE skills)
        // GET /api/utils/GetRecentSearchedSkills?userId={guid}
        // Returns the most recent 3 (or fewer) UNIQUE searched skills in STACK order (most recent first)
        // Example: If user searches: Design → Cooking → Photography → Cooking → Teaching
        //          Returns: ["Teaching", "Cooking", "Photography"] (most recent unique skills)
        // Uses SET logic to eliminate duplicates while preserving recency
        // -------------------------
        [Authorize]
        [HttpGet("GetRecentSearchedSkills")]
        public async Task<IActionResult> GetRecentSearchedSkills([FromQuery] string? userId = null)
        {
            // Resolve user id from claims or query parameter
            var userIdClaim = userId ?? GetUserIdFromClaims();

            if (string.IsNullOrWhiteSpace(userIdClaim))
            {
                return BadRequest(new { message = "User ID is required. Please provide userId query parameter or ensure you're authenticated." });
            }

            _logger.LogInformation($"Fetching recent searched skills for userId: {userIdClaim}");

            try
            {
                // Query ALL searches for this user, ordered by most recent first
                var allSearches = await _context.SkillSearchLogs
                    .Where(log => log.UserId == userIdClaim && !string.IsNullOrWhiteSpace(log.Skill))
                    .OrderByDescending(log => log.SearchTimeUtc)  // Most recent first (STACK - LIFO)
                    .Select(log => new
                    {
                        skill = log.Skill.Trim(),  // Normalize whitespace
                        searchedAt = log.SearchTimeUtc,
                        county = log.County
                    })
                    .ToListAsync();

                // Use HashSet to track unique skills (case-insensitive) and LinkedList to maintain order
                var uniqueSkills = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
                var recentSearches = new List<object>();

                // Iterate through searches and add only unique skills (first occurrence = most recent)
                foreach (var search in allSearches)
                {
                    // Check if this skill hasn't been added yet (case-insensitive comparison)
                    if (uniqueSkills.Add(search.skill))
                    {
                        // Add to results (first time we've seen this skill)
                        recentSearches.Add(new
                        {
                            skill = search.skill,
                            searchedAt = search.searchedAt,
                            county = search.county
                        });

                        // Stop when we have 3 unique skills
                        if (recentSearches.Count >= 3)
                            break;
                    }
                }

                _logger.LogInformation($"✅ Found {recentSearches.Count} unique recent searches for user {userIdClaim} (from {allSearches.Count} total searches)");

                return Ok(new
                {
                    userId = userIdClaim,
                    recentSearches = recentSearches,  // Array format: [most recent unique, ..., oldest unique of the 3]
                    count = recentSearches.Count,
                    totalSearches = allSearches.Count,
                    message = recentSearches.Count == 0
                        ? "No search history found for this user."
                        : $"Returning {recentSearches.Count} most recent UNIQUE search(es) in STACK order (most recent first)."
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"❌ Failed to fetch recent searches for user {userIdClaim}");
                return StatusCode(500, new { message = "An error occurred while fetching search history.", error = ex.Message });
            }
        }

        // -------------------------
        // NEW ENDPOINT: Get Chat History (All Users Chatted With)
        // GET /api/utils/GetChatHistory
        // Returns all unique users the logged-in user has previously exchanged messages with
        // Requires authentication - reads userId from JWT token claims
        // -------------------------
        [Authorize]
        [HttpGet("GetChatHistory")]
        public async Task<IActionResult> GetChatHistory()
        {
            // Get current user ID from JWT token claims
            var currentUserIdClaim = GetUserIdFromClaims();

            if (string.IsNullOrWhiteSpace(currentUserIdClaim) || !Guid.TryParse(currentUserIdClaim, out var currentUserId))
            {
                _logger.LogWarning("GetChatHistory: Unable to resolve userId from claims");
                return Unauthorized(new { message = "User authentication required. Please login again." });
            }

            _logger.LogInformation($"Fetching chat history for userId: {currentUserId}");

            try
            {
                // Step 1: Get all unique user IDs the current user has chatted with
                // This includes both messages sent by the user (ReceiverId) and received by the user (SenderId)
                var sentMessageReceiverIds = await _context.ChatMessages
                    .Where(m => m.SenderId == currentUserId)
                    .Select(m => m.ReceiverId)
                    .Distinct()
                    .ToListAsync();

                var receivedMessageSenderIds = await _context.ChatMessages
                    .Where(m => m.ReceiverId == currentUserId)
                    .Select(m => m.SenderId)
                    .Distinct()
                    .ToListAsync();

                // Combine and deduplicate user IDs
                var chattedUserIds = sentMessageReceiverIds
                    .Union(receivedMessageSenderIds)
                    .Distinct()
                    .ToList();

                if (chattedUserIds.Count == 0)
                {
                    _logger.LogInformation($"No chat history found for userId: {currentUserId}");
                    return Ok(new List<object>());
                }

                _logger.LogInformation($"Found {chattedUserIds.Count} unique users in chat history for userId: {currentUserId}");

                // Step 2: Fetch user profile details from SignUps table
                var chattedUsers = await _context.SignUps
                    .Where(u => chattedUserIds.Contains(u.Id))
                    .Select(u => new
                    {
                        userId = u.Id.ToString(),
                        fullName = u.FullName,
                        skill = (u.Skills != null && u.Skills.Count > 0)
                            ? u.Skills.FirstOrDefault(s => !string.IsNullOrWhiteSpace(s)) ?? string.Empty
                            : string.Empty,
                        county = u.CityOrTown ?? string.Empty,
                        country = u.Country ?? string.Empty,
                        contact = u.Email ?? string.Empty,
                        skills = u.Skills ?? new List<string>()
                    })
                    .ToListAsync();

                _logger.LogInformation($"✅ Successfully retrieved {chattedUsers.Count} user profiles for chat history");

                return Ok(chattedUsers);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"❌ Failed to fetch chat history for user {currentUserId}");
                return StatusCode(500, new
                {
                    message = "An error occurred while fetching chat history.",
                    error = ex.Message
                });
            }
        }


        // Add this helper method inside the UtilsController class to fix CS0103

        private string? GetUserIdFromClaims()
        {
            if (User == null || !User.Identity.IsAuthenticated)
            {
                _logger?.LogWarning("GetUserIdFromClaims: User is null or not authenticated");
                return null;
            }

            var candidateClaimTypes = new[]
            {
                "userId",           // Custom claim
                ClaimTypes.NameIdentifier,  // Standard claim
                "sub",              // JWT standard
                "id",
                "nameid"
            };

            foreach (var ct in candidateClaimTypes)
            {
                var c = User.FindFirst(ct);
                if (c != null && !string.IsNullOrWhiteSpace(c.Value))
                {
                    _logger?.LogInformation($"Found userId in claim type '{ct}': {c.Value}");
                    return c.Value;
                }
            }

            _logger?.LogWarning("No userId claim found in any candidate claim types");
            return null;
        }
    }
}