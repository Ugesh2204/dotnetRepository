using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationandAuthorization.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageUrl { get; set; }
        public DateTime DateOfBirth { get; set; } 

        //Gender Male female
        public Gender Gender {get;set;}

        //Height in feet and inch
        public int Feet { get; set; }
        public double Inch { get; set; }


        //Chatuser wil a  collection of messages
        public virtual ICollection<Message> Messages { get; set; }

        public List<Pet> Pets { get; set; }
        public List<Watchlist> Watchlists { get; set; }
        public List<NotificationApplicationUser> NotificationApplicationUsers { get; set; }

    }

    public enum Gender
    {
        Male,
        Female
    }
}
