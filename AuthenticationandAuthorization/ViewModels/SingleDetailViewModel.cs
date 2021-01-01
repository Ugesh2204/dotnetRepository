using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationandAuthorization.ViewModels
{
    public class SingleDetailViewModel
    {

        public string Id { get; set; }
       
        public string UserName { get; set; }

        //public string ImgUrl { get; set; }

        public IFormFile Photo{get; set;}
    }
}
