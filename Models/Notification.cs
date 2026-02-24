using System.ComponentModel.DataAnnotations;

namespace NipeNikupe.Models
{
    public class Notification
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public Guid RecipientId { get; set; }

        [Required]
        public Guid ChatId { get; set; }

        [Required]
        [MaxLength(200)]
        public string MessagePreview { get; set; } = string.Empty;

        public DateTime TimestampUtc { get; set; } = DateTime.UtcNow;

        public bool IsRead { get; set; } = false;

        // Navigation properties
        public ChatMessage? Chat { get; set; }

        // Optional: Track the sender for display purposes
        public Guid? SenderId { get; set; }

        // Notification type (chat, rating, session invite, etc.)
        [MaxLength(50)]
        public string NotificationType { get; set; } = "chat";
    }
}
