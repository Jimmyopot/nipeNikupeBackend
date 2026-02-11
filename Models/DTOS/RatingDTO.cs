using System.ComponentModel.DataAnnotations;

namespace NipeNikupe.Models.DTOS
{
    public class RatingDTO
    {
        [Required]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        public int Rating { get; set; }

        [MaxLength(100, ErrorMessage = "Quick feedback must be 100 characters or fewer.")]
        public string? QuickFeedback { get; set; }

        [MaxLength(500, ErrorMessage = "Comment must be 500 characters or fewer.")]
        public string? Comment { get; set; }

        // Optional: target user id (if front-end wants to indicate who is being rated)
        public Guid? TargetUserId { get; set; }
    }
}
