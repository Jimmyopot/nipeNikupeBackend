using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NipeNikupe.Data;
using NipeNikupe.Models;

namespace NipeNikupe.Controllers
{
    [Route("api/users")]
    [ApiController]
    //[Authorize]
    public class UserControllers : ControllerBase

    {
        private readonly AppDbContext _context;

        public UserControllers(AppDbContext context) { 
            _context = context;
        }

        [HttpGet("GetUsers")]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _context.users.Select(u => new {
                u.Id,
                u.Name,
                u.Email
            }).ToListAsync();

            return Ok(users);
        }

        [HttpPost("CreateUser")]
        public async Task<IActionResult> CreateUser([FromBody] User user)
        {
            Console.WriteLine($"📥 Incoming request: {System.Text.Json.JsonSerializer.Serialize(user)}");
            if (user == null || string.IsNullOrEmpty(user.Name) || string.IsNullOrEmpty(user.Email) || string.IsNullOrEmpty(user.Password))
            {
                return BadRequest("Invalid user data.");
            }
            _context.users.Add(user);
            await _context.SaveChangesAsync();
            //return CreatedAtAction(nameof(GetUsers), new { id = user.Id }, new { user.Id, user.Name, user.Email });
            return Ok(user);
        }

        [HttpGet("Ping")]
        public IActionResult Ping()
        {
            Console.WriteLine("✅ Ping endpoint hit!");
            return Ok("Backend is runningtyyyt 🚀");
        }
    }
}
