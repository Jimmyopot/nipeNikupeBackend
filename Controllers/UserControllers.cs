using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NipeNikupe.Data;
using NipeNikupe.Models;
using NipeNikupe.Models.DTOS;

namespace NipeNikupe.Controllers
{
    [Route("api/users")]
    [ApiController]
    //[Authorize]
    public class UserControllers : ControllerBase

    {
        private readonly AppDbContext _context;
        private readonly PasswordHasher<SignUp> _passwordHasher = new();

        public UserControllers(AppDbContext context) { 
            _context = context;
        }

        [HttpGet("GetAllUsers")]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _context.SignUps
                .Select(u => new
                {
                    u.Id,
                    u.FullName,
                    u.Email,
                    u.PhoneNumber,
                    u.Country,
                    u.CityOrTown,
                    u.LocalityOrArea,
                    u.Skills,
                    u.AvailableDate,
                    u.AvailableTime,
                    isFirstTimeLoggingIn = u.LastLoginAt == null
                })
                .ToListAsync();

            return Ok(users);
        }

        [HttpPut("UpdateProfile/{id}")]
        public async Task<IActionResult> UpdateProfile(Guid id, [FromBody] SignUpDTO request)
        {
            var user = await _context.SignUps.FindAsync(id);
            if (user == null)
                return NotFound(new { message = "User not found." });

            // Optionally, check for email/phone conflicts with other users
            bool emailConflict = _context.SignUps.Any(u => u.Email == request.Email && u.Id != id);
            bool phoneConflict = _context.SignUps.Any(u => u.PhoneNumber == request.PhoneNumber && u.Id != id);
            if (emailConflict || phoneConflict)
            {
                var errors = new List<string>();
                if (emailConflict) errors.Add("Email already exists.");
                if (phoneConflict) errors.Add("Phone number already exists.");
                return Conflict(new { message = string.Join(" ", errors) });
            }

            user.FullName = request.FullName;
            user.Email = request.Email;
            user.PhoneNumber = request.PhoneNumber;
            user.Country = request.Country;
            user.CityOrTown = request.CityOrTown;
            user.LocalityOrArea = request.LocalityOrArea;
            user.Skills = request.Skills ?? new List<string>();
            user.AvailableDate = request.AvailableDate;
            user.AvailableTime = request.AvailableTime;

            // Only update password if a new one is provided
            if (!string.IsNullOrWhiteSpace(request.Password))
                user.PasswordHash = _passwordHasher.HashPassword(user, request.Password);

            _context.SignUps.Update(user);
            await _context.SaveChangesAsync();

            return Ok(new
            {
                message = "Profile updated successfully.",
                user = new
                {
                    user.Id,
                    user.FullName,
                    user.Email,
                    user.PhoneNumber,
                    user.Country,
                    user.CityOrTown,
                    user.LocalityOrArea,
                    user.Skills,
                    user.AvailableDate,
                    user.AvailableTime
                }
            });
        }

        // ------------------------
        // Suggested matches endpoint
        // GET /api/users/suggested-matches/{userId}?limit=3&county=Nairobi
        // ------------------------
        [HttpGet("GetSuggestedMatches/{userId}")]
        public async Task<IActionResult> GetSuggestedMatches(Guid userId, [FromQuery] int limit = 3, [FromQuery] string? county = null)
        {
            if (limit <= 0) limit = 3;
            limit = Math.Min(limit, 12); // reasonable upper bound

            // Find current user
            var current = await _context.SignUps.AsNoTracking().FirstOrDefaultAsync(u => u.Id == userId);
            if (current == null)
                return NotFound(new { message = "Current user not found." });

            // Normalize current user skills
            var currentSkills = (current.Skills ?? new List<string>())
                .Where(s => !string.IsNullOrWhiteSpace(s))
                .Select(s => s.Trim().ToLowerInvariant())
                .ToHashSet();

            // Prepare candidate query: exclude current user, optionally filter by county to reduce dataset
            var candidatesQuery = _context.SignUps
                .AsNoTracking()
                .Where(u => u.Id != userId);

            if (!string.IsNullOrWhiteSpace(county))
            {
                var normCounty = county.Trim().ToLowerInvariant();
                candidatesQuery = candidatesQuery.Where(u =>
                    (u.CityOrTown ?? "").ToLower().Contains(normCounty) ||
                    (u.LocalityOrArea ?? "").ToLower().Contains(normCounty));
            }

            // Load candidates (select minimal fields)
            var candidates = await candidatesQuery
                .Select(u => new
                {
                    u.Id,
                    u.FullName,
                    u.Email,
                    u.PhoneNumber,
                    u.Country,
                    u.CityOrTown,
                    u.LocalityOrArea,
                    u.Skills
                })
                .ToListAsync();

            var rng = new Random();

            // Compute match score (number of overlapping skills) and matched skill names
            var scored = new List<(Guid Id, string FullName, string Email, string Phone, string Country, string City, string Locality, List<string> MatchedSkills, int MatchScore)>();

            foreach (var c in candidates)
            {
                var cSkills = (c.Skills ?? new List<string>())
                    .Where(s => !string.IsNullOrWhiteSpace(s))
                    .Select(s => s.Trim())
                    .ToList();

                if (cSkills.Count == 0)
                {
                    // no skills — skip for matching stage (may be used in fallback)
                    continue;
                }

                var matched = cSkills
                    .Select(s => new { Raw = s, Lower = s.ToLowerInvariant() })
                    .Where(s => currentSkills.Contains(s.Lower))
                    .Select(s => s.Raw)
                    .ToList();

                if (matched.Count > 0)
                {
                    scored.Add((c.Id, c.FullName, c.Email, c.PhoneNumber, c.Country, c.CityOrTown, c.LocalityOrArea, matched, matched.Count));
                }
            }

            var results = new List<object>();

            if (scored.Count > 0)
            {
                // Order by match score desc, then randomize within same score group to get fresh sets on each request
                var grouped = scored
                    .GroupBy(x => x.MatchScore)
                    .OrderByDescending(g => g.Key);

                foreach (var g in grouped)
                {
                    var shuffled = g.OrderBy(_ => rng.Next()).ToList();
                    foreach (var item in shuffled)
                    {
                        results.Add(new
                        {
                            userId = item.Id,
                            fullName = item.FullName,
                            skillMatches = item.MatchedSkills,
                            matchScore = item.MatchScore,
                            county = item.City ?? string.Empty,
                            location = item.Locality ?? string.Empty,
                            contact = item.Email
                        });

                        if (results.Count >= limit) break;
                    }
                    if (results.Count >= limit) break;
                }
            }

            // If not enough matches, fill with random users (excluding current and already included)
            if (results.Count < limit)
            {
                var includedIds = results.Select(r => Guid.Parse(((dynamic)r).userId)).ToHashSet();

                var fallbackCandidates = candidates
                    .Where(c => !includedIds.Contains(c.Id))
                    .ToList();

                // Shuffle fallback candidates
                var shuffledFallback = fallbackCandidates.OrderBy(_ => rng.Next()).ToList();

                foreach (var f in shuffledFallback)
                {
                    results.Add(new
                    {
                        userId = f.Id,
                        fullName = f.FullName,
                        skillMatches = (f.Skills ?? new List<string>()).Take(3).ToList(),
                        matchScore = 0,
                        county = f.CityOrTown ?? string.Empty,
                        location = f.LocalityOrArea ?? string.Empty,
                        contact = f.Email
                    });

                    if (results.Count >= limit) break;
                }
            }

            // Ensure we only return 'limit' items
            var final = results.Take(limit).ToList();

            return Ok(final);
        }

    }
}
