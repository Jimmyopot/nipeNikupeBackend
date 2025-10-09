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

    }
}
