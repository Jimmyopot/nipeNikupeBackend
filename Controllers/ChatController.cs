//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.SignalR;
//using Microsoft.EntityFrameworkCore;
//using NipeNikupe.Data;
//using NipeNikupe.Hubs;
//using NipeNikupe.Models;

//namespace NipeNikupe.Controllers
//{
//    [ApiController]
//    [Route("api/chat")]
//    [Authorize]
//    public class ChatController : ControllerBase
//    {
//        private readonly AppDbContext _db;
//        private readonly IHubContext<ChatHub> _hub;

//        public ChatController(AppDbContext db, IHubContext<ChatHub> hub)
//        {
//            _db = db;
//            _hub = hub;
//        }

//        // REST send (also broadcasts)
//        [HttpPost("send")]
//        public async Task<IActionResult> SendMessage([FromBody] SendMessageRequest req)
//        {
//            if (!Guid.TryParse(User.FindFirst("userId")?.Value, out var senderId))
//                return BadRequest("Invalid user claim.");

//            var msg = new ChatMessage
//            {
//                SenderId = senderId,
//                ReceiverId = req.ReceiverId,
//                Text = req.Text,
//                TimestampUtc = DateTime.UtcNow,
//                SkillExchangeSessionId = req.SkillExchangeSessionId
//            };

//            _db.ChatMessages.Add(msg);
//            await _db.SaveChangesAsync();

//            if (req.SkillExchangeSessionId.HasValue)
//                await _hub.Clients.Group(req.SkillExchangeSessionId.Value.ToString()).SendAsync("ReceiveMessage", msg);
//            else
//                await _hub.Clients.User(req.ReceiverId.ToString()).SendAsync("ReceiveMessage", msg);

//            return Ok(msg);
//        }

//        // Get history between two users or by session
//        [HttpGet("history")]
//        public async Task<IActionResult> GetHistory([FromQuery] Guid? withUserId, [FromQuery] Guid? sessionId, [FromQuery] int limit = 100)
//        {
//            if (!Guid.TryParse(User.FindFirst("userId")?.Value, out var myId))
//                return BadRequest("Invalid user claim.");

//            IQueryable<ChatMessage> query = _db.ChatMessages.AsNoTracking().OrderByDescending(m => m.TimestampUtc);

//            if (sessionId.HasValue)
//            {
//                query = query.Where(m => m.SkillExchangeSessionId == sessionId.Value);
//            }
//            else if (withUserId.HasValue)
//            {
//                var other = withUserId.Value;
//                query = query.Where(m =>
//                    (m.SenderId == myId && m.ReceiverId == other) ||
//                    (m.SenderId == other && m.ReceiverId == myId));
//            }
//            else
//            {
//                return BadRequest("Provide withUserId or sessionId.");
//            }

//            var messages = await query.Take(limit).ToListAsync();
//            return Ok(messages.OrderBy(m => m.TimestampUtc)); // return ascending
//        }

//        // Mark many messages as read (REST)
//        [HttpPost("mark-read")]
//        public async Task<IActionResult> MarkRead([FromBody] Guid[] messageIds)
//        {
//            if (!Guid.TryParse(User.FindFirst("userId")?.Value, out var userId))
//                return BadRequest("Invalid user claim.");

//            var messages = await _db.ChatMessages
//                .Where(m => messageIds.Contains(m.Id) && m.ReceiverId == userId)
//                .ToListAsync();

//            if (!messages.Any()) return NotFound();

//            foreach (var m in messages)
//            {
//                m.IsRead = true;
//                m.DeliveryStatus = Models.DeliveryStatus.Read;
//            }

//            await _db.SaveChangesAsync();

//            // notify senders
//            foreach (var m in messages)
//            {
//                await _hub.Clients.User(m.SenderId.ToString()).SendAsync("MessageRead", new { messageId = m.Id, readerId = userId });
//            }

//            return Ok();
//        }

//        // Create or join skill exchange session
//        [HttpPost("session")]
//        public async Task<IActionResult> CreateSession([FromBody] CreateSessionRequest req)
//        {
//            if (!Guid.TryParse(User.FindFirst("userId")?.Value, out var userId))
//                return BadRequest("Invalid user claim.");

//            var session = new SkillExchangeSession
//            {
//                Title = req.Title,
//                CreatedByUserId = userId,
//                ParticipantIds = req.ParticipantIds ?? new List<Guid> { userId }
//            };

//            if (!session.ParticipantIds.Contains(userId)) session.ParticipantIds.Add(userId);

//            _db.SkillExchangeSessions.Add(session);
//            await _db.SaveChangesAsync();

//            return Ok(session);
//        }
//    }

//    // DTOs
//    public record SendMessageRequest(Guid ReceiverId, string Text, Guid? SkillExchangeSessionId);
//    public record CreateSessionRequest(string Title, List<Guid>? ParticipantIds);
//}


using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using NipeNikupe.Data;
using NipeNikupe.Hubs;
using NipeNikupe.Models;

namespace NipeNikupe.Controllers
{
    [ApiController]
    [Route("api/chat")]
    [Authorize]
    public class ChatController : ControllerBase
    {
        private readonly AppDbContext _db;
        private readonly IHubContext<ChatHub> _chatHub;
        private readonly IHubContext<NotificationHub> _notificationHub;
        private readonly ILogger<ChatController> _logger;

        public ChatController(
            AppDbContext db,
            IHubContext<ChatHub> chatHub,
            IHubContext<NotificationHub> notificationHub,
            ILogger<ChatController> logger)
        {
            _db = db;
            _chatHub = chatHub;
            _notificationHub = notificationHub;
            _logger = logger;
        }

        /// <summary>
        /// Send a chat message (REST endpoint)
        /// POST /api/chat/send
        /// Also creates a notification for the recipient
        /// </summary>
        [HttpPost("send")]
        public async Task<IActionResult> SendMessage([FromBody] SendMessageRequest req)
        {
            if (!Guid.TryParse(User.FindFirst("userId")?.Value, out var senderId))
                return BadRequest(new { success = false, message = "Invalid user claim." });

            if (string.IsNullOrWhiteSpace(req.Text) || req.Text.Length > 5000)
                return BadRequest(new { success = false, message = "Message text is required (max 5000 chars)." });

            // Create chat message
            var msg = new ChatMessage
            {
                SenderId = senderId,
                ReceiverId = req.ReceiverId,
                Text = req.Text,
                TimestampUtc = DateTime.UtcNow,
                SkillExchangeSessionId = req.SkillExchangeSessionId,
                IsRead = false,
                DeliveryStatus = Models.DeliveryStatus.Sent
            };

            _db.ChatMessages.Add(msg);
            await _db.SaveChangesAsync();

            // Get sender info for notification
            var sender = await _db.SignUps
                .Where(u => u.Id == senderId)
                .Select(u => new { u.FullName })
                .FirstOrDefaultAsync();

            var senderName = sender?.FullName ?? "Someone";

            // Create notification for recipient
            var messagePreview = req.Text.Length > 100
                ? req.Text.Substring(0, 97) + "..."
                : req.Text;

            var notification = new Notification
            {
                RecipientId = req.ReceiverId,
                ChatId = msg.Id,
                MessagePreview = $"{senderName}: {messagePreview}",
                SenderId = senderId,
                NotificationType = "chat",
                TimestampUtc = DateTime.UtcNow,
                IsRead = false
            };

            _db.Notifications.Add(notification);
            await _db.SaveChangesAsync();

            _logger.LogInformation($"Chat message sent: {msg.Id} from {senderId} to {req.ReceiverId}");

            // Broadcast chat message via SignalR
            if (req.SkillExchangeSessionId.HasValue)
            {
                await _chatHub.Clients.Group(req.SkillExchangeSessionId.Value.ToString())
                    .SendAsync("ReceiveMessage", new
                    {
                        msg.Id,
                        msg.SenderId,
                        msg.ReceiverId,
                        msg.Text,
                        msg.TimestampUtc,
                        msg.IsRead,
                        msg.DeliveryStatus,
                        msg.SkillExchangeSessionId
                    });
            }
            else
            {
                await _chatHub.Clients.User(req.ReceiverId.ToString())
                    .SendAsync("ReceiveMessage", new
                    {
                        msg.Id,
                        msg.SenderId,
                        msg.ReceiverId,
                        msg.Text,
                        msg.TimestampUtc,
                        msg.IsRead,
                        msg.DeliveryStatus
                    });
            }

            // Push notification to recipient via SignalR
            await _notificationHub.Clients.User(req.ReceiverId.ToString())
                .SendAsync("NewNotification", new
                {
                    notificationId = notification.Id,
                    recipientId = notification.RecipientId,
                    chatId = notification.ChatId,
                    messagePreview = notification.MessagePreview,
                    timestamp = notification.TimestampUtc,
                    isRead = notification.IsRead,
                    senderId = notification.SenderId,
                    senderName = senderName,
                    notificationType = notification.NotificationType
                });

            // Get unread count for recipient
            var unreadCount = await _db.Notifications
                .Where(n => n.RecipientId == req.ReceiverId && !n.IsRead)
                .CountAsync();

            await _notificationHub.Clients.User(req.ReceiverId.ToString())
                .SendAsync("UnreadCountUpdate", unreadCount);

            return Ok(new
            {
                success = true,
                message = "Message sent successfully.",
                data = new
                {
                    messageId = msg.Id,
                    notificationId = notification.Id,
                    text = msg.Text,
                    timestamp = msg.TimestampUtc
                }
            });
        }

        /// <summary>
        /// Get chat history between two users or by session
        /// GET /api/chat/history?withUserId={guid}&limit=100
        /// </summary>
        [HttpGet("history")]
        public async Task<IActionResult> GetHistory(
            [FromQuery] Guid? withUserId,
            [FromQuery] Guid? sessionId,
            [FromQuery] int limit = 100)
        {
            if (!Guid.TryParse(User.FindFirst("userId")?.Value, out var myId))
                return BadRequest(new { success = false, message = "Invalid user claim." });

            if (limit <= 0 || limit > 500)
                limit = 100;

            IQueryable<ChatMessage> query = _db.ChatMessages
                .AsNoTracking()
                .OrderByDescending(m => m.TimestampUtc);

            if (sessionId.HasValue)
            {
                query = query.Where(m => m.SkillExchangeSessionId == sessionId.Value);
            }
            else if (withUserId.HasValue)
            {
                var other = withUserId.Value;
                query = query.Where(m =>
                    (m.SenderId == myId && m.ReceiverId == other) ||
                    (m.SenderId == other && m.ReceiverId == myId));
            }
            else
            {
                return BadRequest(new { success = false, message = "Provide withUserId or sessionId." });
            }

            var messages = await query.Take(limit).ToListAsync();

            return Ok(new
            {
                success = true,
                data = messages.OrderBy(m => m.TimestampUtc).ToList(),
                count = messages.Count
            });
        }

        /// <summary>
        /// Mark chat messages as read
        /// POST /api/chat/mark-read
        /// </summary>
        [HttpPost("mark-read")]
        public async Task<IActionResult> MarkRead([FromBody] Guid[] messageIds)
        {
            if (!Guid.TryParse(User.FindFirst("userId")?.Value, out var userId))
                return BadRequest(new { success = false, message = "Invalid user claim." });

            var messages = await _db.ChatMessages
                .Where(m => messageIds.Contains(m.Id) && m.ReceiverId == userId)
                .ToListAsync();

            if (!messages.Any())
                return NotFound(new { success = false, message = "No messages found." });

            foreach (var m in messages)
            {
                m.IsRead = true;
                m.DeliveryStatus = Models.DeliveryStatus.Read;
            }

            await _db.SaveChangesAsync();

            // Notify senders via SignalR
            foreach (var m in messages)
            {
                await _chatHub.Clients.User(m.SenderId.ToString())
                    .SendAsync("MessageRead", new
                    {
                        messageId = m.Id,
                        readerId = userId,
                        readAt = DateTime.UtcNow
                    });
            }

            return Ok(new { success = true, message = "Messages marked as read.", count = messages.Count });
        }

        /// <summary>
        /// Create or join skill exchange session
        /// POST /api/chat/session
        /// </summary>
        [HttpPost("session")]
        public async Task<IActionResult> CreateSession([FromBody] CreateSessionRequest req)
        {
            if (!Guid.TryParse(User.FindFirst("userId")?.Value, out var userId))
                return BadRequest(new { success = false, message = "Invalid user claim." });

            var session = new SkillExchangeSession
            {
                Title = req.Title,
                CreatedByUserId = userId,
                ParticipantIds = req.ParticipantIds ?? new List<Guid> { userId }
            };

            if (!session.ParticipantIds.Contains(userId))
                session.ParticipantIds.Add(userId);

            _db.SkillExchangeSessions.Add(session);
            await _db.SaveChangesAsync();

            return Ok(new
            {
                success = true,
                message = "Session created successfully.",
                data = session
            });
        }
    }

    // DTOs
    public record SendMessageRequest(Guid ReceiverId, string Text, Guid? SkillExchangeSessionId);
    public record CreateSessionRequest(string Title, List<Guid>? ParticipantIds);
}