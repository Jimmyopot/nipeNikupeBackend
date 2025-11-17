namespace NipeNikupe.Models
{
    public class SkillExchangeSession
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = string.Empty;
        public Guid CreatedByUserId { get; set; }
        public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;

        // participants (store user ids as JSON array or maintain join table for many-to-many)
        public List<Guid> ParticipantIds { get; set; } = new();

        public List<ChatMessage> Messages { get; set; } = new();
    }
}
