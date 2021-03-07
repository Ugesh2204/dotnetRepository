using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationandAuthorization.Models
{
    public class NewMessageApplicationUser
    {
        [Key]
        public int Id { get; set; }
        public int MessageId { get; set; }
        public NewMessage NewMessage { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
