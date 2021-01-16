using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticationandAuthorization.Data;
using AuthenticationandAuthorization.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationandAuthorization.Services
{
    //Notification to interact with our database
    public class NotificationRepository : INotificationRepository
    {
        public AppDbContext _db { get;}
        public IWatchlistRepository _watchlistRepository { get; }
        public NotificationRepository(AppDbContext db, IWatchlistRepository watchlistRepository)
        {
            _db = db;
            _watchlistRepository = watchlistRepository;
        }

        //Create Notification
        public void Create(Notification notification, int petId)
        {
            _db.Notifications.Add(notification);
            _db.SaveChanges();

            //TODO: Assign notification to users
            //Get all pet id whose status has currentle been changed
            var watchlists = _watchlistRepository.GetWatchlistFromPetId(petId);
            foreach (var watchlist in watchlists)
            {
                //Assign notification notification to all user who has change the status of there pet list
                var userNotification = new NotificationApplicationUser();
                userNotification.ApplicationUserId = watchlist.UserId;
                userNotification.NotificationId = notification.Id;

                _db.UserNotifications.Add(userNotification);
                _db.SaveChanges();
            }
        }

        public List<NotificationApplicationUser> GetUserNotification(string userId)
        {
            //go to the db find all the Notif with userid equal to the past userid form our
            //notification application user tbale and perfom  join with Notif table user notfi
            return _db.UserNotifications.Where(u => u.ApplicationUserId.Equals(userId))
                                        .Include(n => n.Notification)
                                        .ToList();
        }

        //Change Read Status for not read to read
        public void ReadNotification(int id)
        {
            var notification = _db.Notifications.FirstOrDefault(n => n.Id == id);
            notification.IsRead = true;
            _db.Notifications.Update(notification);
            _db.SaveChanges();
        }
    }
}
