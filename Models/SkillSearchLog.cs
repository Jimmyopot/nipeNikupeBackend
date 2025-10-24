namespace NipeNikupe.Models
{
    public class SkillSearchLog
    {
        public int Id { get; set; }
        public string Skill { get; set; } = string.Empty;
        public string? County { get; set; }
        public string? UserId { get; set; }            // store claim user id if available
        public string? IpAddress { get; set; }
        public string? UserAgent { get; set; }
        public int ResultsCount { get; set; }
        public DateTime SearchTimeUtc { get; set; } = DateTime.UtcNow;
    }
}
