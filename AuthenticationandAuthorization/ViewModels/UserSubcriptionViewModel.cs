using AuthenticationandAuthorization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationandAuthorization.ViewModels
{
    public class UserSubcriptionViewModel
    {
        public List<Membership> Memberships { get; set; }
        public List<Membership_Price> Membership_Prices { get; set; }
        public List<Subcription> Subcriptions { get; set; }


    }
}
 