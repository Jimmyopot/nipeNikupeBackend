using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using NipeNikupe.Data;
using NipeNikupe.Models;
using Microsoft.EntityFrameworkCore;

namespace NipeNikupe.Hubs
{
    [Authorize]
    public class NotificationHub : Hub
    {
        private readonly AppDbContext _db;
        private readonly ILogger<NotificationHub> _logger;

        public NotificationHub(AppDbContext db, ILogger<NotificationHub> logger)
        {
            _db = db;
            _logger = logger;
        }

        public override async Task OnConnectedAsync()
        {
            var userId = Context.UserIdentifier;
            _logger.LogInformation($"NotificationHub: User {userId} connected");
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            var userId = Context.UserIdentifier;
            _logger.LogInformation($"NotificationHub: User {userId} disconnected");
            await base.OnDisconnectedAsync(exception);
        }

        /// <summary>
        /// Client calls this to request unread notification count
        /// </summary>
        public async Task GetUnreadCount()
        {
            if (!Guid.TryParse(Context.UserIdentifier, out var userId))
                return;

            var unreadCount = await _db.Notifications
                .Where(n => n.RecipientId == userId && !n.IsRead)
                .CountAsync();

            await Clients.Caller.SendAsync("UnreadCountUpdate", unreadCount);
        }

        /// <summary>
        /// Mark all notifications as read for current user
        /// </summary>
        public async Task MarkAllAsRead()
        {
            if (!Guid.TryParse(Context.UserIdentifier, out var userId))
                return;

            var unreadNotifications = await _db.Notifications
                .Where(n => n.RecipientId == userId && !n.IsRead)
                .ToListAsync();

            foreach (var notification in unreadNotifications)
            {
                notification.IsRead = true;
            }

            await _db.SaveChangesAsync();
            await Clients.Caller.SendAsync("AllNotificationsMarkedRead");
        }
    }
}
