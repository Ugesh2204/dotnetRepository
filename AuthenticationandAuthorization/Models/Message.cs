using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationandAuthorization.Models
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }
        public int ToUserId { get; set; } = 0;
        public string MessageHeader { get; set; } = "";
        public string MessageBody { get; set; }
        public string Url { get; set; } = "";
        public string FromUserName { get; set; } = "";
        public string ToUserName { get; set; } = "";
        public DateTime MessageDtTm { get; set; }
        public int Comment_status { get; set; }

        public virtual ApplicationUser FromUser { get; set; }
    }
}
