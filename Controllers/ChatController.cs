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
        private readonly IHubContext<ChatHub> _hub;

        public ChatController(AppDbContext db, IHubContext<ChatHub> hub)
        {
            _db = db;
            _hub = hub;
        }

        // REST send (also broadcasts)
        [HttpPost("send")]
        public async Task<IActionResult> SendMessage([FromBody] SendMessageRequest req)
        {
            if (!Guid.TryParse(User.FindFirst("userId")?.Value, out var senderId))
                return BadRequest("Invalid user claim.");

            var msg = new ChatMessage
            {
                SenderId = senderId,
                ReceiverId = req.ReceiverId,
                Text = req.Text,
                TimestampUtc = DateTime.UtcNow,
                SkillExchangeSessionId = req.SkillExchangeSessionId
            };

            _db.ChatMessages.Add(msg);
            await _db.SaveChangesAsync();

            if (req.SkillExchangeSessionId.HasValue)
                await _hub.Clients.Group(req.SkillExchangeSessionId.Value.ToString()).SendAsync("ReceiveMessage", msg);
            else
                await _hub.Clients.User(req.ReceiverId.ToString()).SendAsync("ReceiveMessage", msg);

            return Ok(msg);
        }

        // Get history between two users or by session
        [HttpGet("history")]
        public async Task<IActionResult> GetHistory([FromQuery] Guid? withUserId, [FromQuery] Guid? sessionId, [FromQuery] int limit = 100)
        {
            if (!Guid.TryParse(User.FindFirst("userId")?.Value, out var myId))
                return BadRequest("Invalid user claim.");

            IQueryable<ChatMessage> query = _db.ChatMessages.AsNoTracking().OrderByDescending(m => m.TimestampUtc);

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
                return BadRequest("Provide withUserId or sessionId.");
            }

            var messages = await query.Take(limit).ToListAsync();
            return Ok(messages.OrderBy(m => m.TimestampUtc)); // return ascending
        }

        // Mark many messages as read (REST)
        [HttpPost("mark-read")]
        public async Task<IActionResult> MarkRead([FromBody] Guid[] messageIds)
        {
            if (!Guid.TryParse(User.FindFirst("userId")?.Value, out var userId))
                return BadRequest("Invalid user claim.");

            var messages = await _db.ChatMessages
                .Where(m => messageIds.Contains(m.Id) && m.ReceiverId == userId)
                .ToListAsync();

            if (!messages.Any()) return NotFound();

            foreach (var m in messages)
            {
                m.IsRead = true;
                m.DeliveryStatus = Models.DeliveryStatus.Read;
            }

            await _db.SaveChangesAsync();

            // notify senders
            foreach (var m in messages)
            {
                await _hub.Clients.User(m.SenderId.ToString()).SendAsync("MessageRead", new { messageId = m.Id, readerId = userId });
            }

            return Ok();
        }

        // Create or join skill exchange session
        [HttpPost("session")]
        public async Task<IActionResult> CreateSession([FromBody] CreateSessionRequest req)
        {
            if (!Guid.TryParse(User.FindFirst("userId")?.Value, out var userId))
                return BadRequest("Invalid user claim.");

            var session = new SkillExchangeSession
            {
                Title = req.Title,
                CreatedByUserId = userId,
                ParticipantIds = req.ParticipantIds ?? new List<Guid> { userId }
            };

            if (!session.ParticipantIds.Contains(userId)) session.ParticipantIds.Add(userId);

            _db.SkillExchangeSessions.Add(session);
            await _db.SaveChangesAsync();

            return Ok(session);
        }
    }

    // DTOs
    public record SendMessageRequest(Guid ReceiverId, string Text, Guid? SkillExchangeSessionId);
    public record CreateSessionRequest(string Title, List<Guid>? ParticipantIds);
}
