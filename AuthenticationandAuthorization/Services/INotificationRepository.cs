using AuthenticationandAuthorization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationandAuthorization.Services
{
    public interface INotificationRepository
    {

        //goes to db and get all the notification of userid
        //Method for notification
        List<NotificationApplicationUser> GetUserNotifications(string userId);

        void Create(Notification notification, int petId);
        //to change the read status on the Notification.cs
        void ReadNotification(int id);

    }
}
