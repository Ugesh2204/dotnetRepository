using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationandAuthorization.ViewModels
{
    public class StudentViewModel
    {
        
        public string Name { get; set; }
        public string Email { get; set; }
        //public string ImageUrl { get; set; }
        //We will use IFORMFILE PHOTO
        //Iform can access the datbase throught IFROM FILES
        // ifrom contain copyTo METHOD that we will use to cpy the photo
        public IFormFile Photo { get; set; }
    }
}
