using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NipeNikupe.Models.DTOS;
using NipeNikupe.Services;

namespace NipeNikupe.Controllers
{
    [ApiController]
    [Route("api/admin")]
    public class AdminController : ControllerBase
    {
        private readonly JwtTokenService _jwtTokenService;
        private readonly ILogger<AdminController> _logger;

        public AdminController(JwtTokenService jwtTokenService, ILogger<AdminController> logger)
        {
            _jwtTokenService = jwtTokenService;
            _logger = logger;
        }

        /// <summary>
        /// Admin Login Endpoint
        /// POST /api/admin/login
        /// Authenticates admin users with backend-defined credentials
        /// </summary>
        /// <param name="request">Admin login credentials (email and password)</param>
        /// <returns>Success response with JWT token or error message</returns>
        [HttpPost("login")]
        [AllowAnonymous]
        public IActionResult Login([FromBody] AdminLoginDTO request)
        {
            try
            {
                // Validate input
                if (string.IsNullOrWhiteSpace(request.Email) || string.IsNullOrWhiteSpace(request.Password))
                {
                    _logger.LogWarning("Admin login attempt with missing credentials");
                    return BadRequest(new
                    {
                        success = false,
                        message = "Email and password are required."
                    });
                }

                // Validate credentials against backend configuration
                if (!AdminCredentials.ValidateCredentials(request.Email, request.Password))
                {
                    _logger.LogWarning($"Failed admin login attempt for email: {request.Email}");

                    // Return same message for security (don't reveal if email exists)
                    return Unauthorized(new
                    {
                        success = false,
                        message = "Invalid email or password."
                    });
                }

                // Generate admin JWT token
                var token = _jwtTokenService.GenerateAdminToken(request.Email);

                _logger.LogInformation($"✅ Successful admin login for: {request.Email} at {DateTime.UtcNow}");

                // Return success response with token
                return Ok(new
                {
                    success = true,
                    message = "Login successful",
                    token = token,
                    admin = new
                    {
                        email = request.Email,
                        role = "Admin",
                        loginTime = DateTime.UtcNow,
                        tokenExpiry = DateTime.UtcNow.AddHours(8) // 8 hours validity
                    }
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "❌ Error during admin login");
                return StatusCode(500, new
                {
                    success = false,
                    message = "An error occurred during login. Please try again later."
                });
            }
        }

        /// <summary>
        /// Check if current user is an authenticated admin
        /// GET /api/admin/check-auth
        /// </summary>
        [HttpGet("check-auth")]
        [Authorize(Roles = "Admin")]
        public IActionResult CheckAuthentication()
        {
            var email = User?.FindFirst("email")?.Value ?? User?.Identity?.Name;
            var isAdmin = User?.IsInRole("Admin") ?? false;

            return Ok(new
            {
                isAuthenticated = User?.Identity?.IsAuthenticated ?? false,
                isAdmin = isAdmin,
                email = email,
                message = isAdmin ? "Admin authenticated successfully." : "Not an admin user."
            });
        }

        /// <summary>
        /// Admin logout endpoint (optional - for logging purposes)
        /// POST /api/admin/logout
        /// </summary>
        [HttpPost("logout")]
        [Authorize(Roles = "Admin")]
        public IActionResult Logout()
        {
            var email = User?.FindFirst("email")?.Value ?? User?.Identity?.Name;
            _logger.LogInformation($"Admin logout: {email} at {DateTime.UtcNow}");

            return Ok(new
            {
                success = true,
                message = "Logout successful. Please clear your token on the client side."
            });
        }
    }
}