using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationandAuthorization.Models
{
    public class Membership_Price
    {
        [Key]
        public int PriceId { get; set; }
        public double Price { get; set; }

        [ForeignKey("MembershipId")]
        public int MembershipId { get; set; }
        public Membership Membership { get; set; }
    }
}
