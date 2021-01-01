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
    public class UserDetailController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        AppDbContext _db;

        public UserDetailController(UserManager<ApplicationUser> userManager, AppDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }
        public IActionResult Index()
        {
            //string userid = User.Identity.GetUserid()

            //var userid = _userManager.GetUserId(HttpContext.User);

            //ApplicationUser user = _userManager.FindByIdAsync(userid).Result;

            return View();
        }
    }
}