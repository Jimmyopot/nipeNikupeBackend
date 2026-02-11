using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NipeNikupe.Data;
using NipeNikupe.Models;
using NipeNikupe.Models.DTOS;

namespace NipeNikupe.Controllers
{
    [ApiController]
    [Route("api/ratings")]
    [Authorize]
    public class RatingsController : ControllerBase
    {
        private readonly AppDbContext _db;

        public RatingsController(AppDbContext db)
        {
            _db = db;
        }

        [HttpPost]
        public async Task<IActionResult> SubmitRating([FromBody] RatingDTO request)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = "Invalid request", errors = ModelState });

            // Resolve rater id from JWT "userId" claim if present
            Guid? raterId = null;
            var claim = User.FindFirst("userId")?.Value;
            if (!string.IsNullOrWhiteSpace(claim) && Guid.TryParse(claim, out var parsed))
                raterId = parsed;

            // Build rating record
            var rating = new Rating
            {
                Score = request.Rating,
                QuickFeedback = string.IsNullOrWhiteSpace(request.QuickFeedback) ? null : request.QuickFeedback.Trim(),
                Comment = string.IsNullOrWhiteSpace(request.Comment) ? null : request.Comment.Trim(),
                RaterId = raterId,
                TargetUserId = request.TargetUserId,
                CreatedAtUtc = DateTime.UtcNow
            };

            _db.Ratings.Add(rating);
            await _db.SaveChangesAsync();

            return Ok(new
            {
                success = true,
                message = "Rating submitted successfully.",
                data = new
                {
                    ratingId = rating.Id,
                    rating = rating.Score,
                    quickFeedback = rating.QuickFeedback,
                    comment = rating.Comment,
                    createdAt = rating.CreatedAtUtc
                }
            });
        }
    }
}
