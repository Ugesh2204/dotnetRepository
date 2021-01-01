using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationandAuthorization.Models
{
    public class Subcription
    {
        [Key]
        public int SubId { get; set; }
        public DateTime StartDate { get; set; }
        //setting date to null
        public DateTime? ExpireDate { get; set; }
        public double Amount { get; set; }
        public string MembershipName { get; set; }
        public string ClientName { get; set; }

        public string PaymentMethod { get; set; }
        public enum EPaymentMethod { Cash = 0, DebitCard = 2, Cheque = 3 }

        public string PaymentDate { get; set; }
        public double AmountToBePaid { get; set; }
        public double RemainingAmount { get; set; }

        public bool Status { get; set; }

        public Subcription()
        {
            Status = false;
        }



        public bool MorePaymentRequired { get; set; }

        [ForeignKey("ApplicationUserId")]
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        [ForeignKey("MembershipId ")]
        public int MembershipId { get; set; }
        public Membership Membership { get; set; }

        //[ForeignKey("PriceId ")]
        //public int PriceId { get; set; }
        //public Membership_Price Membership_Prices { get; set; }

       
    }
}



