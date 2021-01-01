using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationandAuthorization.ViewModels
{
    public class ListOfavtiveMembersViewModel
    {
        public int Id { get; set; }
        public string Userid {get;set;}
        public string Uname { get; set; }
        public string Email { get; set; }
        public bool ActiveMember { get; set; }

    }
}
