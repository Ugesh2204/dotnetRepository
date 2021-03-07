using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticationandAuthorization.Data;
using AuthenticationandAuthorization.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationandAuthorization.Services
{
    public class RapidNotification : IRapidNotification
    {


        public AppDbContext _db { get; }
        public RapidNotification(AppDbContext db)
        {
            _db = db;
        }

        public void Create(NewMessage newMessage)
        {
            _db.Add(newMessage);
             _db.SaveChanges();
        }

        public List<NewMessageApplicationUser> GetUserNotifications(string userId)
        {
            //go to the db find all the Notif with userid equal to the past userid form our
            //notification application user tbale and perfom  join with Notif table user notfi
            //return _db.UserNotifications.Where(u => u.ApplicationUserId.Equals(userId))
            //                            .Include(n => n.Notification)
            //                            .ToList();

            return _db.UserMessageNotif.Where(u => u.ApplicationUserId.Equals(userId))
                                       .Include(n => n.NewMessage).ToList();
        }

        public void ReadNotification(int id)
        {
            throw new NotImplementedException();
        }
    }
}


