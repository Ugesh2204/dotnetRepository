using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticationandAuthorization.Data;
using AuthenticationandAuthorization.Models;
using AuthenticationandAuthorization.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationandAuthorization.Controllers
{
    public class UserProfileController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
         AppDbContext db;

        public UserProfileController(UserManager<ApplicationUser> userManager, AppDbContext _db)
        {

            _userManager = userManager;
            db = _db;

        }

        public IActionResult Index()
        {
            var userid = _userManager.GetUserId(HttpContext.User);
            ApplicationUser user = _userManager.FindByIdAsync(userid).Result;

            return View(user);
        }


        [HttpGet]
        public IActionResult Edit()
        {
            var userid = _userManager.GetUserId(HttpContext.User);
            if(userid == null)
            {
                return RedirectToAction("Login", "Account");
            }
            else
            {
                ApplicationUser user = _userManager.FindByIdAsync(userid).Result;

                return View(user);
            }
            
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ApplicationUser Userdetails)
        {


            ApplicationUser user = await _userManager.FindByIdAsync(Userdetails.Id);

             user.FirstName = Userdetails.FirstName;
          

            //In this method i want to save the update of current user
            //Identity class we can identify if the record is update successfully or not

            IdentityResult result = await _userManager.UpdateAsync(user);
            //await db.SaveChangesAsync();

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "UserProfile");
            }
           

            return View();
        }




        public IActionResult TEST()
        {
            return View();
        }
    }
}