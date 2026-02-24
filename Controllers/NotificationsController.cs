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
    [Route("api/notifications")]
    [Authorize]
    public class NotificationsController : ControllerBase
    {
        private readonly AppDbContext _db;
        private readonly IHubContext<NotificationHub> _notificationHub;
        private readonly ILogger<NotificationsController> _logger;

        public NotificationsController(
            AppDbContext db,
            IHubContext<NotificationHub> notificationHub,
            ILogger<NotificationsController> logger)
        {
            _db = db;
            _notificationHub = notificationHub;
            _logger = logger;
        }

        /// <summary>
        /// Get all notifications for the current user
        /// GET /api/notifications
        /// Supports filtering by isRead status
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetNotifications(
            [FromQuery] bool? isRead = null,
            [FromQuery] int limit = 50,
            [FromQuery] int offset = 0)
        {
            if (!Guid.TryParse(User.FindFirst("userId")?.Value, out var userId))
                return BadRequest(new { success = false, message = "Invalid user claim." });

            if (limit <= 0 || limit > 100)
                limit = 50;

            var query = _db.Notifications
                .AsNoTracking()
                .Where(n => n.RecipientId == userId);

            // Filter by read status if specified
            if (isRead.HasValue)
            {
                query = query.Where(n => n.IsRead == isRead.Value);
            }

            var totalCount = await query.CountAsync();

            var notifications = await query
                .OrderByDescending(n => n.TimestampUtc)
                .Skip(offset)
                .Take(limit)
                .Select(n => new
                {
                    notificationId = n.Id,
                    recipientId = n.RecipientId,
                    chatId = n.ChatId,
                    messagePreview = n.MessagePreview,
                    timestamp = n.TimestampUtc,
                    isRead = n.IsRead,
                    senderId = n.SenderId,
                    notificationType = n.NotificationType
                })
                .ToListAsync();

            _logger.LogInformation($"Retrieved {notifications.Count} notifications for user {userId}");

            return Ok(new
            {
                success = true,
                data = notifications,
                pagination = new
                {
                    limit,
                    offset,
                    total = totalCount,
                    returned = notifications.Count
                }
            });
        }

        /// <summary>
        /// Get notifications for a specific user (admin/support use)
        /// GET /api/notifications/{userId}
        /// </summary>
        [HttpGet("{userId}")]
        public async Task<IActionResult> GetUserNotifications(
            Guid userId,
            [FromQuery] bool? isRead = null,
            [FromQuery] int limit = 50)
        {
            // Verify the requesting user has permission (either same user or admin)
            if (!Guid.TryParse(User.FindFirst("userId")?.Value, out var requesterId))
                return BadRequest(new { success = false, message = "Invalid user claim." });

            // For now, only allow users to see their own notifications
            // Add role check here if you want admins to see any user's notifications
            if (requesterId != userId)
                return Forbid();

            var query = _db.Notifications
                .AsNoTracking()
                .Where(n => n.RecipientId == userId);

            if (isRead.HasValue)
            {
                query = query.Where(n => n.IsRead == isRead.Value);
            }

            var notifications = await query
                .OrderByDescending(n => n.TimestampUtc)
                .Take(limit)
                .Select(n => new
                {
                    notificationId = n.Id,
                    recipientId = n.RecipientId,
                    chatId = n.ChatId,
                    messagePreview = n.MessagePreview,
                    timestamp = n.TimestampUtc,
                    isRead = n.IsRead,
                    senderId = n.SenderId,
                    notificationType = n.NotificationType
                })
                .ToListAsync();

            return Ok(new
            {
                success = true,
                data = notifications,
                count = notifications.Count
            });
        }

        /// <summary>
        /// Mark a notification as read
        /// PATCH /api/notifications/{notificationId}/mark-read
        /// </summary>
        [HttpPatch("{notificationId}/mark-read")]
        public async Task<IActionResult> MarkAsRead(Guid notificationId)
        {
            if (!Guid.TryParse(User.FindFirst("userId")?.Value, out var userId))
                return BadRequest(new { success = false, message = "Invalid user claim." });

            var notification = await _db.Notifications
                .FirstOrDefaultAsync(n => n.Id == notificationId && n.RecipientId == userId);

            if (notification == null)
                return NotFound(new { success = false, message = "Notification not found." });

            if (notification.IsRead)
                return Ok(new { success = true, message = "Notification already marked as read." });

            notification.IsRead = true;
            await _db.SaveChangesAsync();

            _logger.LogInformation($"Notification {notificationId} marked as read by user {userId}");

            // Update unread count via SignalR
            var unreadCount = await _db.Notifications
                .Where(n => n.RecipientId == userId && !n.IsRead)
                .CountAsync();

            await _notificationHub.Clients.User(userId.ToString())
                .SendAsync("UnreadCountUpdate", unreadCount);

            return Ok(new
            {
                success = true,
                message = "Notification marked as read.",
                data = new
                {
                    notificationId = notification.Id,
                    chatId = notification.ChatId,
                    isRead = notification.IsRead
                }
            });
        }

        /// <summary>
        /// Mark multiple notifications as read
        /// PATCH /api/notifications/mark-read-bulk
        /// </summary>
        [HttpPatch("mark-read-bulk")]
        public async Task<IActionResult> MarkMultipleAsRead([FromBody] Guid[] notificationIds)
        {
            if (!Guid.TryParse(User.FindFirst("userId")?.Value, out var userId))
                return BadRequest(new { success = false, message = "Invalid user claim." });

            var notifications = await _db.Notifications
                .Where(n => notificationIds.Contains(n.Id) && n.RecipientId == userId && !n.IsRead)
                .ToListAsync();

            if (!notifications.Any())
                return NotFound(new { success = false, message = "No unread notifications found." });

            foreach (var notification in notifications)
            {
                notification.IsRead = true;
            }

            await _db.SaveChangesAsync();

            _logger.LogInformation($"Marked {notifications.Count} notifications as read for user {userId}");

            // Update unread count
            var unreadCount = await _db.Notifications
                .Where(n => n.RecipientId == userId && !n.IsRead)
                .CountAsync();

            await _notificationHub.Clients.User(userId.ToString())
                .SendAsync("UnreadCountUpdate", unreadCount);

            return Ok(new
            {
                success = true,
                message = $"{notifications.Count} notification(s) marked as read.",
                count = notifications.Count,
                unreadCount = unreadCount
            });
        }

        /// <summary>
        /// Mark all notifications as read for current user
        /// PATCH /api/notifications/mark-all-read
        /// </summary>
        [HttpPatch("mark-all-read")]
        public async Task<IActionResult> MarkAllAsRead()
        {
            if (!Guid.TryParse(User.FindFirst("userId")?.Value, out var userId))
                return BadRequest(new { success = false, message = "Invalid user claim." });

            var notifications = await _db.Notifications
                .Where(n => n.RecipientId == userId && !n.IsRead)
                .ToListAsync();

            if (!notifications.Any())
                return Ok(new { success = true, message = "No unread notifications." });

            foreach (var notification in notifications)
            {
                notification.IsRead = true;
            }

            await _db.SaveChangesAsync();

            _logger.LogInformation($"All {notifications.Count} notifications marked as read for user {userId}");

            await _notificationHub.Clients.User(userId.ToString())
                .SendAsync("UnreadCountUpdate", 0);

            return Ok(new
            {
                success = true,
                message = $"All {notifications.Count} notification(s) marked as read."
            });
        }

        /// <summary>
        /// Get unread notification count
        /// GET /api/notifications/unread-count
        /// </summary>
        [HttpGet("unread-count")]
        public async Task<IActionResult> GetUnreadCount()
        {
            if (!Guid.TryParse(User.FindFirst("userId")?.Value, out var userId))
                return BadRequest(new { success = false, message = "Invalid user claim." });

            var unreadCount = await _db.Notifications
                .Where(n => n.RecipientId == userId && !n.IsRead)
                .CountAsync();

            return Ok(new
            {
                success = true,
                unreadCount = unreadCount
            });
        }

        /// <summary>
        /// Delete a notification
        /// DELETE /api/notifications/{notificationId}
        /// </summary>
        [HttpDelete("{notificationId}")]
        public async Task<IActionResult> DeleteNotification(Guid notificationId)
        {
            if (!Guid.TryParse(User.FindFirst("userId")?.Value, out var userId))
                return BadRequest(new { success = false, message = "Invalid user claim." });

            var notification = await _db.Notifications
                .FirstOrDefaultAsync(n => n.Id == notificationId && n.RecipientId == userId);

            if (notification == null)
                return NotFound(new { success = false, message = "Notification not found." });

            _db.Notifications.Remove(notification);
            await _db.SaveChangesAsync();

            _logger.LogInformation($"Notification {notificationId} deleted by user {userId}");

            return Ok(new { success = true, message = "Notification deleted successfully." });
        }
    }
}