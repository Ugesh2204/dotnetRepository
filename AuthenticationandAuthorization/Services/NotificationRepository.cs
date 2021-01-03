using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticationandAuthorization.Data;
using AuthenticationandAuthorization.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationandAuthorization.Services
{
    public class NotificationRepository : INotificationRepository
    {
        public AppDbContext _db { get;}
        public NotificationRepository(AppDbContext db)
        {
            _db = db; 
        }

        public void Create(Notification notification)
        {
            _db.Notifications.Add(notification);
            _db.SaveChanges();

            //TODO: Assign notification to users
        }

        public List<NotificationApplicationUser> GetUserNotification(string userId)
        {
            //go to the db find all the Notif with userid equal to the past userid form our
            //notification application user tbale and perfom  join with Notif table user notfi
            return _db.UserNotifications.Where(u => u.ApplicationUserId.Equals(userId))
                                        .Include(n => n.Notification)
                                        .ToList();
        }

        public void ReadNotification(int id)
        {
            var notification = _db.Notifications.FirstOrDefault(n => n.Id == id);
            notification.IsRead = true;
            _db.Notifications.Update(notification);
            _db.SaveChanges();
        }
    }
}
