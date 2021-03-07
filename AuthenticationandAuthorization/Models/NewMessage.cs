using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationandAuthorization.Models
{
    public class NewMessage
    {
        [Key]
        public int MessageId { get; set; }
        public string Subject { get; set; }
        public string MessageText { get; set; }
        public bool MessageStatus { get; set; }
        public bool IsRead { get; set; } = false;

        public string MyUserId { get; set; }

        public List<NewMessageApplicationUser> NewMessageApplicationUsers { get; set; }

    }
}
