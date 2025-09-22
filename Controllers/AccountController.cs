using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using NipeNikupe.Models;
using NipeNikupe.Models.DTOS;
using NipeNikupe.Data;
using System.Threading.Tasks;
using NipeNikupe.Services;

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

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO request)
        {
            if (string.IsNullOrWhiteSpace(request.Email) || string.IsNullOrWhiteSpace(request.Password))
                return BadRequest("Email and password are required.");

            var user = await Task.Run(() => _context.SignUps.FirstOrDefault(u => u.Email == request.Email));
            if (user == null)
                return Unauthorized("Invalid credentials.");

            var result = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, request.Password);
            if (result != PasswordVerificationResult.Success)
                return Unauthorized("Invalid credentials.");

            var token = _jwtTokenService.GenerateToken(user);

            return Ok(new { token });
        }
    }
}