using AuthenticationandAuthorization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationandAuthorization.ViewModels
{
    public class SubcriptionViewModel
    {
        //This is our cascading class that we are going to use in our index as model
        public int MembershipId { get; set; }
        public int PriceId { get; set; }
        public DateTime Date { get; set; }
        
    }
}
