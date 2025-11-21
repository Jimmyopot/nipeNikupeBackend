using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using NipeNikupe.Data;
using NipeNikupe.Models;
using Microsoft.EntityFrameworkCore;

namespace NipeNikupe.Hubs
{
    [Authorize]
    public class ChatHub : Hub
    {
        private readonly AppDbContext _db;
        public ChatHub(AppDbContext db)
        {
            _db = db;
        }

        // Client calls SendMessage -> persisted + delivered to target(s)
        public async Task SendMessage(Guid receiverId, string text, Guid? skillExchangeSessionId = null)
        {
            var userIdClaim = Context.UserIdentifier;
            if (!Guid.TryParse(userIdClaim, out var senderId))
            {
                throw new HubException("Invalid sender id claim.");
            }

            var message = new ChatMessage
            {
                SenderId = senderId,
                ReceiverId = receiverId,
                Text = text,
                TimestampUtc = DateTime.UtcNow,
                IsRead = false,
                DeliveryStatus = Models.DeliveryStatus.Sent,
                SkillExchangeSessionId = skillExchangeSessionId
            };

            _db.ChatMessages.Add(message);
            await _db.SaveChangesAsync();

            // If group session is provided, broadcast to the session group
            if (skillExchangeSessionId.HasValue)
            {
                await Clients.Group(skillExchangeSessionId.Value.ToString())
                    .SendAsync("ReceiveMessage", message);
            }
            else
            {
                // One-to-one: send to receiver's connections
                await Clients.User(receiverId.ToString()).SendAsync("ReceiveMessage", message);
            }

            // Optionally notify sender about successful send (with persisted id)
            await Clients.Caller.SendAsync("MessageSent", message);
        }

        // Mark messages read (client calls with message ids or session)
        public async Task MarkAsRead(Guid[] messageIds)
        {
            var userIdClaim = Context.UserIdentifier;
            if (!Guid.TryParse(userIdClaim, out var userId))
                return;

            var messages = await _db.ChatMessages
                .Where(m => messageIds.Contains(m.Id) && m.ReceiverId == userId)
                .ToListAsync();

            if (messages.Count == 0) return;

            foreach (var m in messages)
            {
                m.IsRead = true;
                m.DeliveryStatus = Models.DeliveryStatus.Read;
            }

            await _db.SaveChangesAsync();

            // notify senders that their messages were read
            foreach (var m in messages)
            {
                await Clients.User(m.SenderId.ToString())
                    .SendAsync("MessageRead", new { messageId = m.Id, readerId = userId });
            }
        }

        // Typing indicator: inform the receiver(s)
        public async Task Typing(Guid targetUserId, bool isTyping, Guid? sessionId = null)
        {
            if (sessionId.HasValue)
                await Clients.Group(sessionId.Value.ToString()).SendAsync("Typing", new { from = Context.UserIdentifier, isTyping });
            else
                await Clients.User(targetUserId.ToString()).SendAsync("Typing", new { from = Context.UserIdentifier, isTyping });
        }

        // Join skill exchange session (group)
        public async Task JoinSession(Guid sessionId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, sessionId.ToString());
        }

        public async Task LeaveSession(Guid sessionId)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, sessionId.ToString());
        }

        public override async Task OnConnectedAsync()
        {
            // Optionally: add connection info in DB or in-memory map
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            // cleanup if you store connections server-side
            await base.OnDisconnectedAsync(exception);
        }
    }
}