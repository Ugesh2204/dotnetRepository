using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationandAuthorization.Models
{
    public class Membership
    {   [Key]
        public int MembershipId { get; set; }
        public string MembershipType { get; set; }
        public List<Membership_Price> Membership_Prices { get; set; }
        //public DateTime Date {get;set;}
        public List<Subcription>Subcriptions { get; set; }


    }
}
