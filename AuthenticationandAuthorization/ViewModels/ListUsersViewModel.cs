using AuthenticationandAuthorization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationandAuthorization.ViewModels
{
    public class ListUsersViewModel
    {

        public int MessageId { get; set; }
        public string Subject { get; set; }
        public string MessageText { get; set; }
        public bool MessageStatus { get; set; }
        public List<ApplicationUser> applicationUsers { get; set; }
    }
}
