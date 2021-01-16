using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationandAuthorization.Models
{
    //Notification table 
    public class Notification
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool IsRead { get; set; } = false;
        public List<NotificationApplicationUser> NotificationApplicationUsers { get; set; }
    }
}
