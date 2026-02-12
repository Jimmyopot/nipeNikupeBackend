using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private readonly ILogger<RatingsController> _logger;

        public RatingsController(AppDbContext db, ILogger<RatingsController> logger)
        {
            _db = db;
            _logger = logger;
        }

        /// <summary>
        /// Submit a new rating for a trading experience
        /// POST /api/ratings
        /// </summary>
        [HttpPost("submit-rating")]
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

            _logger.LogInformation($"Rating submitted: Id={rating.Id}, Score={rating.Score}, RaterId={raterId}, TargetUserId={request.TargetUserId}");

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

        /// <summary>
        /// Retrieve a list of submitted ratings with optional filtering and pagination
        /// GET /api/ratings?userId={guid}&limit=20&offset=0
        /// </summary>
        /// <param name="userId">Optional: Filter ratings by rater user ID</param>
        /// <param name="targetUserId">Optional: Filter ratings by target user ID (who was rated)</param>
        /// <param name="limit">Maximum number of ratings to return (default: 20, max: 100)</param>
        /// <param name="offset">Pagination offset for large datasets (default: 0)</param>
        [HttpGet("get-ratings")]
        public async Task<IActionResult> GetRatings(
            [FromQuery] Guid? userId = null,
            [FromQuery] Guid? targetUserId = null,
            [FromQuery] int limit = 20,
            [FromQuery] int offset = 0)
        {
            try
            {
                // Validate pagination parameters
                if (limit <= 0 || limit > 100)
                {
                    return BadRequest(new
                    {
                        success = false,
                        message = "Limit must be between 1 and 100."
                    });
                }

                if (offset < 0)
                {
                    return BadRequest(new
                    {
                        success = false,
                        message = "Offset must be 0 or greater."
                    });
                }

                // Build query with optional filters
                var query = _db.Ratings.AsNoTracking();

                // Filter by rater user ID (who submitted the rating)
                if (userId.HasValue)
                {
                    query = query.Where(r => r.RaterId == userId.Value);
                    _logger.LogInformation($"Filtering ratings by RaterId: {userId.Value}");
                }

                // Filter by target user ID (who was rated)
                if (targetUserId.HasValue)
                {
                    query = query.Where(r => r.TargetUserId == targetUserId.Value);
                    _logger.LogInformation($"Filtering ratings by TargetUserId: {targetUserId.Value}");
                }

                // Get total count for pagination
                var totalCount = await query.CountAsync();

                // Apply pagination and ordering (most recent first)
                var ratings = await query
                    .OrderByDescending(r => r.CreatedAtUtc)
                    .Skip(offset)
                    .Take(limit)
                    .Select(r => new
                    {
                        ratingId = r.Id.ToString(),
                        rating = r.Score,
                        quickFeedback = r.QuickFeedback ?? string.Empty,
                        comment = r.Comment ?? string.Empty,
                        createdAt = r.CreatedAtUtc,
                        userId = r.RaterId.HasValue ? r.RaterId.Value.ToString() : null,
                        targetUserId = r.TargetUserId.HasValue ? r.TargetUserId.Value.ToString() : null
                    })
                    .ToListAsync();

                _logger.LogInformation($"Retrieved {ratings.Count} ratings (total: {totalCount}, offset: {offset}, limit: {limit})");

                return Ok(new
                {
                    success = true,
                    message = ratings.Count == 0 
                        ? "No ratings found." 
                        : $"Successfully retrieved {ratings.Count} rating(s).",
                    data = ratings,
                    pagination = new
                    {
                        limit,
                        offset,
                        total = totalCount,
                        returned = ratings.Count,
                        hasMore = (offset + limit) < totalCount
                    }
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving ratings");
                return StatusCode(500, new
                {
                    success = false,
                    message = "An error occurred while retrieving ratings.",
                    error = ex.Message
                });
            }
        }

        /// <summary>
        /// Get rating statistics for a specific user (e.g., average rating, total ratings)
        /// GET /api/ratings/stats/{targetUserId}
        /// </summary>
        /// <param name="targetUserId">The user ID to get rating statistics for</param>
        [HttpGet("stats/{targetUserId}")]
        public async Task<IActionResult> GetRatingStats(Guid targetUserId)
        {
            try
            {
                var ratings = await _db.Ratings
                    .Where(r => r.TargetUserId == targetUserId)
                    .ToListAsync();

                if (ratings.Count == 0)
                {
                    return Ok(new
                    {
                        success = true,
                        message = "No ratings found for this user.",
                        data = new
                        {
                            targetUserId = targetUserId.ToString(),
                            totalRatings = 0,
                            averageRating = 0.0,
                            ratingDistribution = new
                            {
                                oneStar = 0,
                                twoStar = 0,
                                threeStar = 0,
                                fourStar = 0,
                                fiveStar = 0
                            }
                        }
                    });
                }

                var averageRating = ratings.Average(r => r.Score);
                var ratingDistribution = ratings
                    .GroupBy(r => r.Score)
                    .ToDictionary(g => g.Key, g => g.Count());

                _logger.LogInformation($"Retrieved rating stats for user {targetUserId}: Avg={averageRating:F2}, Total={ratings.Count}");

                return Ok(new
                {
                    success = true,
                    message = "Rating statistics retrieved successfully.",
                    data = new
                    {
                        targetUserId = targetUserId.ToString(),
                        totalRatings = ratings.Count,
                        averageRating = Math.Round(averageRating, 2),
                        ratingDistribution = new
                        {
                            oneStar = ratingDistribution.GetValueOrDefault(1, 0),
                            twoStar = ratingDistribution.GetValueOrDefault(2, 0),
                            threeStar = ratingDistribution.GetValueOrDefault(3, 0),
                            fourStar = ratingDistribution.GetValueOrDefault(4, 0),
                            fiveStar = ratingDistribution.GetValueOrDefault(5, 0)
                        },
                        topQuickFeedback = ratings
                            .Where(r => !string.IsNullOrWhiteSpace(r.QuickFeedback))
                            .GroupBy(r => r.QuickFeedback)
                            .OrderByDescending(g => g.Count())
                            .Take(5)
                            .Select(g => new { feedback = g.Key, count = g.Count() })
                            .ToList()
                    }
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error retrieving rating stats for user {targetUserId}");
                return StatusCode(500, new
                {
                    success = false,
                    message = "An error occurred while retrieving rating statistics.",
                    error = ex.Message
                });
            }
        }
    }
}
