using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NipeNikupe.Data;
using NipeNikupe.Models;
using NipeNikupe.Models.DTOS;
using NipeNikupe.Services;
using System.Threading.Tasks;

namespace NipeNikupe.Controllers
{
    [ApiController]
    [Route("api/account")]
    public class AccountController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly JwtTokenService _jwtTokenService;
        private readonly PasswordHasher<SignUp> _passwordHasher = new();

        public AccountController(AppDbContext context, JwtTokenService jwtTokenService)
        {
            _context = context;
            _jwtTokenService = jwtTokenService;
        }

        [HttpPost("SignUp")]
        public async Task<IActionResult> SignUp([FromBody] SignUpDTO request)
        {
            // Basic validation
            if (string.IsNullOrWhiteSpace(request.Email) || string.IsNullOrWhiteSpace(request.Password))
                return BadRequest("Email and password are required.");

            // TODO: Check if user already exists (by email/phone) in your data store
            bool userExists = _context.SignUps.Any(u => u.Email == request.Email || u.PhoneNumber == request.PhoneNumber);
            if (userExists)
                return Conflict("A user with this email or phone number already exists.");

            var user = new SignUp
            {
                FullName = request.FullName,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber,
                PasswordHash = "", // Temporary value to satisfy required property
                Country = request.Country,
                CityOrTown = request.CityOrTown,
                LocalityOrArea = request.LocalityOrArea,
                Skills = request.Skills ?? new List<string>(),
                AvailableDate = request.AvailableDate,
                AvailableTime = request.AvailableTime
            };

            user.PasswordHash = _passwordHasher.HashPassword(user, request.Password);

            // TODO: Save user to your data store
            _context.SignUps.Add(user);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Registration successful." });
        }

        [HttpPost("CheckUserUnique")]
        public IActionResult CheckUserUnique([FromBody] CheckUserUniqueDTO request)
        {
            if (string.IsNullOrWhiteSpace(request.Email) && string.IsNullOrWhiteSpace(request.PhoneNumber))
                return BadRequest("Email or phone number is required.");

            var emailExists = !string.IsNullOrWhiteSpace(request.Email) && _context.SignUps.Any(u => u.Email == request.Email);
            var phoneExists = !string.IsNullOrWhiteSpace(request.PhoneNumber) && _context.SignUps.Any(u => u.PhoneNumber == request.PhoneNumber);

            if (emailExists || phoneExists)
            {
                var errors = new List<string>();
                if (emailExists) errors.Add("Email already exists.");
                if (phoneExists) errors.Add("Phone number already exists.");

                return Conflict(new
                {
                    message = string.Join(" ", errors),
                    emailConflict = emailExists,
                    phoneConflict = phoneExists
                });
            }

            return Ok(new { message = "User is unique. No conflicts found." });
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO request)
        {
            if (string.IsNullOrWhiteSpace(request.Email) || string.IsNullOrWhiteSpace(request.Password))
                return BadRequest(new { success = false, message = "Email and password are required." });

            var user = await _context.SignUps.FirstOrDefaultAsync(u => u.Email == request.Email);

            if (user == null)
                return Unauthorized(new { success = false, message = "Invalid credentials." });

            // Verify password BEFORE updating database
            var result = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, request.Password);

            if (result != PasswordVerificationResult.Success)
                return Unauthorized(new { success = false, message = "Invalid credentials." });

            // Check if first time login BEFORE updating LastLoginAt
            var isFirstTimeLoggingIn = user.LastLoginAt == null;

            // Update LastLoginAt on successful login
            user.LastLoginAt = DateTime.UtcNow;
            _context.SignUps.Update(user);
            await _context.SaveChangesAsync();

            var token = _jwtTokenService.GenerateToken(user);

            return Ok(new
            {
                success = true,
                message = "Successfully logged in",
                token,
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
                    user.AvailableTime,
                    isFirstTimeLoggingIn,
                    token
                }
            });
        }

        [HttpGet("CheckAuthentication")]
        [AllowAnonymous]
        public ActionResult<bool> CheckAuthentication()
        {
            return User.Identity.IsAuthenticated;
        }
    }
}