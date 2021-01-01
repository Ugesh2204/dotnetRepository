﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationandAuthorization.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name="User Name")]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
   
        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}
