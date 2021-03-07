using AuthenticationandAuthorization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationandAuthorization.Services
{

    

    public interface IRapidNotification
    {
        List<NewMessageApplicationUser> GetUserNotifications(string userId);
        void Create(NewMessage newMessage);
        void ReadNotification(int id);
    }
}
