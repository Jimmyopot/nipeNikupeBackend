namespace NipeNikupe.Models
{
    public class ChatMessage
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid SenderId { get; set; }
        public Guid ReceiverId { get; set; } // for direct one-to-one messages
        public string Text { get; set; } = string.Empty;
        public DateTime TimestampUtc { get; set; } = DateTime.UtcNow;
        public bool IsRead { get; set; } = false;
        public Models.DeliveryStatus DeliveryStatus { get; set; } = Models.DeliveryStatus.Sent;

        // optional session grouping (skill exchange)
        public Guid? SkillExchangeSessionId { get; set; }
        public SkillExchangeSession? SkillExchangeSession { get; set; }
}
}
