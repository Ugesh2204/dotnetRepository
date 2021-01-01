using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticationandAuthorization.Data;
using AuthenticationandAuthorization.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationandAuthorization.Controllers
{
    public class NotificationMessageController : Controller
    {

     
        public IActionResult Index()
        {
            return View();
        }
    }
}