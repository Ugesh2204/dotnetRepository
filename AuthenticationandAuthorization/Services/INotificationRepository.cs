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
        //Method
        List<NotificationApplicationUser> GetUserNotification(string userId);

        void Create(Notification notification);

        void ReadNotification(int id);

    }
}
