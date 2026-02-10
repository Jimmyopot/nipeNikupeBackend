namespace NipeNikupe.Models
{
    public class Rating
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        // The numeric rating (1..5)
        public int Score { get; set; }

        // Optional quick feedback tag(s) - a short phrase or comma-separated tags
        public string? QuickFeedback { get; set; }

        // Optional comment up to 500 characters
        public string? Comment { get; set; }

        // The user who submitted the rating (from JWT claim "userId")
        public Guid? RaterId { get; set; }

        // Optional: the user who was rated (useful for aggregation/search)
        public Guid? TargetUserId { get; set; }

        public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    }
}
