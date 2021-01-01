using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationandAuthorization.ViewModels
{
    public class ProfileUserViewModel
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageUrl { get; set; }
        public DateTime DateOfBirth { get; set; }

        //Gender Male female
        public Gender Gender { get; set; }

        //Height in feet and inch
        public int Feet { get; set; }
        public double Inch { get; set; }
      
        public IFormFile Photo { get; set; }


    }
}
