using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NipeNikupe.Data;

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
    }
}
