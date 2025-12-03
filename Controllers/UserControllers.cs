using Microsoft.AspNetCore.Authorization;
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
        //[HttpGet("GetSuggestedMatches/{userId}")]
        //[Authorize]
        //public async Task<IActionResult> GetSuggestedMatches(Guid userId, [FromQuery] int limit = 3, [FromQuery] string? county = null)
        //{
        //    if (limit <= 0) limit = 3;
        //    limit = Math.Min(limit, 12); // reasonable upper bound

        //    // Find current user
        //    var current = await _context.SignUps.AsNoTracking().FirstOrDefaultAsync(u => u.Id == userId);
        //    if (current == null)
        //        return NotFound(new { message = "Current user not found." });

        //    // Normalize current user skills
        //    var currentSkills = (current.Skills ?? new List<string>())
        //        .Where(s => !string.IsNullOrWhiteSpace(s))
        //        .Select(s => s.Trim().ToLowerInvariant())
        //        .ToHashSet();

        //    // Prepare candidate query: exclude current user, optionally filter by county to reduce dataset
        //    var candidatesQuery = _context.SignUps
        //        .AsNoTracking()
        //        .Where(u => u.Id != userId);

        //    if (!string.IsNullOrWhiteSpace(county))
        //    {
        //        var normCounty = county.Trim().ToLowerInvariant();
        //        candidatesQuery = candidatesQuery.Where(u =>
        //            (u.CityOrTown ?? "").ToLower().Contains(normCounty) ||
        //            (u.LocalityOrArea ?? "").ToLower().Contains(normCounty));
        //    }

        //    // Load candidates (select minimal fields)
        //    var candidates = await candidatesQuery
        //        .Select(u => new
        //        {
        //            u.Id,
        //            u.FullName,
        //            u.Email,
        //            u.PhoneNumber,
        //            u.Country,
        //            u.CityOrTown,
        //            u.LocalityOrArea,
        //            u.Skills
        //        })
        //        .ToListAsync();

        //    var rng = new Random();

        //    // Compute match score (number of overlapping skills) and matched skill names
        //    var scored = new List<(Guid Id, string FullName, string Email, string Phone, string Country, string City, string Locality, List<string> MatchedSkills, int MatchScore)>();

        //    foreach (var c in candidates)
        //    {
        //        var cSkills = (c.Skills ?? new List<string>())
        //            .Where(s => !string.IsNullOrWhiteSpace(s))
        //            .Select(s => s.Trim())
        //            .ToList();

        //        if (cSkills.Count == 0)
        //        {
        //            // no skills — skip for matching stage (may be used in fallback)
        //            continue;
        //        }

        //        var matched = cSkills
        //            .Select(s => new { Raw = s, Lower = s.ToLowerInvariant() })
        //            .Where(s => currentSkills.Contains(s.Lower))
        //            .Select(s => s.Raw)
        //            .ToList();

        //        if (matched.Count > 0)
        //        {
        //            scored.Add((c.Id, c.FullName, c.Email, c.PhoneNumber, c.Country, c.CityOrTown, c.LocalityOrArea, matched, matched.Count));
        //        }
        //    }

        //    var results = new List<object>();

        //    if (scored.Count > 0)
        //    {
        //        // Order by match score desc, then randomize within same score group to get fresh sets on each request
        //        var grouped = scored
        //            .GroupBy(x => x.MatchScore)
        //            .OrderByDescending(g => g.Key);

        //        foreach (var g in grouped)
        //        {
        //            var shuffled = g.OrderBy(_ => rng.Next()).ToList();
        //            foreach (var item in shuffled)
        //            {
        //                results.Add(new
        //                {
        //                    userId = item.Id,
        //                    fullName = item.FullName,
        //                    skillMatches = item.MatchedSkills,
        //                    matchScore = item.MatchScore,
        //                    county = item.City ?? string.Empty,
        //                    location = item.Locality ?? string.Empty,
        //                    contact = item.Email
        //                });

        //                if (results.Count >= limit) break;
        //            }
        //            if (results.Count >= limit) break;
        //        }
        //    }

        //    // If not enough matches, fill with random users (excluding current and already included)
        //    if (results.Count < limit)
        //    {
        //        var includedIds = results.Select(r => Guid.Parse(((dynamic)r).userId)).ToHashSet();

        //        var fallbackCandidates = candidates
        //            .Where(c => !includedIds.Contains(c.Id))
        //            .ToList();

        //        // Shuffle fallback candidates
        //        var shuffledFallback = fallbackCandidates.OrderBy(_ => rng.Next()).ToList();

        //        foreach (var f in shuffledFallback)
        //        {
        //            results.Add(new
        //            {
        //                userId = f.Id,
        //                fullName = f.FullName,
        //                skillMatches = (f.Skills ?? new List<string>()).Take(3).ToList(),
        //                matchScore = 0,
        //                county = f.CityOrTown ?? string.Empty,
        //                location = f.LocalityOrArea ?? string.Empty,
        //                contact = f.Email
        //            });

        //            if (results.Count >= limit) break;
        //        }
        //    }

        //    // Ensure we only return 'limit' items
        //    var final = results.Take(limit).ToList();

        //    return Ok(final);
        //}


        // ------------------------
        // Suggested matches endpoint - REFACTORED
        // GET /api/users/GetSuggestedMatches/{userId}
        // Returns exactly 3 users based on skill similarity
        // Refreshes every 24 hours with a deterministic daily seed
        // ------------------------
        [HttpGet("GetSuggestedMatches/{userId}")]
        [Authorize]
        public async Task<IActionResult> GetSuggestedMatches(Guid userId)
        {
            // Find current user
            var current = await _context.SignUps.AsNoTracking().FirstOrDefaultAsync(u => u.Id == userId);
            if (current == null)
                return NotFound(new { message = "Current user not found." });

            // Normalize current user skills (case-insensitive)
            var currentSkills = (current.Skills ?? new List<string>())
                .Where(s => !string.IsNullOrWhiteSpace(s))
                .Select(s => s.Trim().ToLowerInvariant())
                .ToList();

            // Load ALL other users (excluding current user)
            var allCandidates = await _context.SignUps
                .AsNoTracking()
                .Where(u => u.Id != userId)
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

            if (allCandidates.Count == 0)
            {
                return Ok(new
                {
                    userId = userId,
                    suggestedMatches = new List<object>(),
                    count = 0,
                    refreshDate = DateTime.UtcNow.Date.AddDays(1),
                    message = "No users available for suggestions."
                });
            }

            // Create a deterministic daily seed (changes every 24 hours)
            // This ensures same results for a given user on the same day
            var today = DateTime.UtcNow.Date;
            var dailySeed = userId.GetHashCode() ^ today.GetHashCode();
            var rng = new Random(dailySeed);

            var results = new List<object>();

            // STEP 1: Try to find users with matching skills
            if (currentSkills.Count > 0)
            {
                // Randomly pick ONE skill from user's skills
                var randomSkillIndex = rng.Next(currentSkills.Count);
                var selectedSkill = currentSkills[randomSkillIndex];

                // Find users who have this skill (case-insensitive)
                var matchingUsers = allCandidates
                    .Where(c =>
                    {
                        var candidateSkills = (c.Skills ?? new List<string>())
                            .Where(s => !string.IsNullOrWhiteSpace(s))
                            .Select(s => s.Trim().ToLowerInvariant())
                            .ToList();

                        return candidateSkills.Contains(selectedSkill);
                    })
                    .ToList();

                if (matchingUsers.Count > 0)
                {
                    // Shuffle matching users with daily seed
                    var shuffledMatching = matchingUsers.OrderBy(_ => rng.Next()).ToList();

                    // Take up to 3 matching users
                    var matchCount = Math.Min(3, shuffledMatching.Count);
                    for (int i = 0; i < matchCount; i++)
                    {
                        var match = shuffledMatching[i];

                        // Find the matched skill in original case for display
                        var displaySkill = (match.Skills ?? new List<string>())
                            .FirstOrDefault(s => s.Trim().ToLowerInvariant() == selectedSkill);

                        // Get all skills for this user (filter out empty/null values)
                        var allUserSkills = (match.Skills ?? new List<string>())
                            .Where(s => !string.IsNullOrWhiteSpace(s))
                            .Select(s => s.Trim())
                            .ToList();

                        results.Add(new
                        {
                            userId = match.Id,
                            fullName = match.FullName,
                            email = match.Email,
                            phoneNumber = match.PhoneNumber,
                            country = match.Country ?? string.Empty,
                            cityOrTown = match.CityOrTown ?? string.Empty,
                            localityOrArea = match.LocalityOrArea ?? string.Empty,
                            matchedSkill = displaySkill ?? selectedSkill,
                            allUserSkills = allUserSkills,
                            matchType = "skill_match"
                        });
                    }
                }
            }

            // STEP 2: Fill remaining slots with random users (if less than 3)
            if (results.Count < 3)
            {
                // Get IDs of already included users
                var includedIds = results.Select(r => ((dynamic)r).userId).Cast<Guid>().ToHashSet();

                // Get remaining candidates
                var remainingCandidates = allCandidates
                    .Where(c => !includedIds.Contains(c.Id))
                    .ToList();

                // Shuffle remaining candidates with daily seed
                var shuffledRemaining = remainingCandidates.OrderBy(_ => rng.Next()).ToList();

                // Fill up to 3 total users
                var neededCount = 3 - results.Count;
                for (int i = 0; i < Math.Min(neededCount, shuffledRemaining.Count); i++)
                {
                    var randomUser = shuffledRemaining[i];

                    // Get first skill or empty string
                    var displaySkill = (randomUser.Skills ?? new List<string>())
                        .Where(s => !string.IsNullOrWhiteSpace(s))
                        .FirstOrDefault() ?? string.Empty;

                    // Get all skills for this user (filter out empty/null values)
                    var allUserSkills = (randomUser.Skills ?? new List<string>())
                        .Where(s => !string.IsNullOrWhiteSpace(s))
                        .Select(s => s.Trim())
                        .ToList();

                    results.Add(new
                    {
                        userId = randomUser.Id,
                        fullName = randomUser.FullName,
                        email = randomUser.Email,
                        phoneNumber = randomUser.PhoneNumber,
                        country = randomUser.Country ?? string.Empty,
                        cityOrTown = randomUser.CityOrTown ?? string.Empty,
                        localityOrArea = randomUser.LocalityOrArea ?? string.Empty,
                        matchedSkill = displaySkill,
                        allSkills = allUserSkills,
                        matchType = "random"
                    });
                }
            }

            return Ok(new
            {
                userId = userId,
                suggestedMatches = results,
                count = results.Count,
                refreshDate = today.AddDays(1), // Next refresh date
                message = results.Count == 0
                    ? "No users available for suggestions."
                    : $"Returning {results.Count} suggested user(s). Results refresh daily."
            });
        }

}
}
