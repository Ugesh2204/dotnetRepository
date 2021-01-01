using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationandAuthorization.ViewModels
{
    public class ResetPasswordViewModel
    {
        //At the time of reseting the password we need 4 fields

        //This we are getting it from email
        public string UserId { get; set; }
        //This we are getting from the generated token link
        public string Token { get; set; }
        //This we are getting it from form
        public string Password { get; set; }
        public  string ConfirmPassword { get; set; }

    }
}
