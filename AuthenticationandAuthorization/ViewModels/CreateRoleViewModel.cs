using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationandAuthorization.ViewModels
{
    public class CreateRoleViewModel
    {
        //need only one property her 

        [Required]
        public string RoleName { get; set; }
    }
}
