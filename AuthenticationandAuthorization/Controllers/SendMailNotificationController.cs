using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticationandAuthorization.Data;
using AuthenticationandAuthorization.HangFire_service;
using AuthenticationandAuthorization.Models;
using AuthenticationandAuthorization.ViewModels;
using Hangfire;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace AuthenticationandAuthorization.Controllers
{
    public class SendMailNotificationController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        AppDbContext _db;

        private readonly IMyEmailService _emailService;
        public SendMailNotificationController(AppDbContext db, UserManager<ApplicationUser> userManager, IMyEmailService emailService)
        {
            _db = db;
            _userManager = userManager;
            _emailService = emailService;
        }


        public IActionResult Index(string Usersearch)
        {


            var today = DateTime.Now;
            var FiveDaysFromtoday = DateTime.Now.AddDays(5);
            var FithteenFromtoday = DateTime.Now.AddDays(15);
            var ThirtyFromtoday = DateTime.Now.AddDays(30);




            //var expireDate = _db.Subcriptions
            //             .Where(x => x.ExpireDate <= today)
            //               .Include(s => s.ApplicationUser)
            //             .ToList();

            //var userquery = from x in _db.Subcriptions select x;



            //    if (!string.IsNullOrEmpty(Usersearch))
            //    {

            //        userquery = userquery.Where(x => x.ApplicationUser.UserName.Contains(Usersearch)
            //         || x.ApplicationUser.Email.Contains(Usersearch));

            //    }

            if (string.IsNullOrEmpty(Usersearch))
            {
                var expireDate = _db.Subcriptions
                        .Include(u => u.ApplicationUser)
                        .OrderBy(d=>d.ExpireDate)
                      .ToList();

                return View(expireDate);
            }
            else if (Usersearch == "5 days to Expire")
            {
                var expireDate = _db.Subcriptions
                          .Where(x => x.ExpireDate <= FiveDaysFromtoday  && x.ExpireDate >= today )
                          .Include(s => s.ApplicationUser)
                          .ToList();

               
                return View(expireDate);
            }

            else if (Usersearch == "15 days to Expire")
            {
                var expireDate = _db.Subcriptions
                          .Where(x => x.ExpireDate <= FithteenFromtoday && x.ExpireDate >= FiveDaysFromtoday)
                          .Include(s => s.ApplicationUser)
                          //.GroupBy(z => z.ExpireDate).First()
                          .ToList();
                return View(expireDate);
            }

            else if (Usersearch == "30 days to Expire")
            {
                var expireDate = _db.Subcriptions
                          .Where(x => x.ExpireDate <= ThirtyFromtoday && x.ExpireDate >= FithteenFromtoday)
                          .Include(s => s.ApplicationUser)
                          //.GroupBy(z => z.ExpireDate).First()
                          .ToList();
                return View(expireDate);
            }

            else {
                ViewBag.msg = "No record found";
            }
          
            return View();
        


            //var expireDate = _db.Subcriptions
            //               .Include(u=>u.ApplicationUser)
            //             .ToList();



            //List<string> listOfavtiveMembers = new List<string>();
            //foreach (var item in expireDate)
            //{
            //    if (item.Status == true)
            //    {
            //        listOfavtiveMembers.Add(item.ApplicationUser.Email);
            //    }

            //};



            //var expireDate = _db.Subcriptions
            //                .Where(x=>x.ExpireDate < today)
            //                .OrderBy(x => x.ExpireDate).ToList();

            //.Select(x => x.Price).SingleOrDefault();

            //This will get all the list of users less 10 days from today

            //var expireDate = _db.Subcriptions
            //             .Where(x => x.ExpireDate <=today)
            //             .Include(s=>s.ApplicationUser)
            //             .ToList();

            //I create a new list to filter members who active = true






            //var toaddr = listOfavtiveMembers.Split(',');

            //var getlistmembers = new ListOfavtiveMembersViewModel()
            //{
            //    Email = listOfavtiveMembers.

            //};


            //var getall = listOfavtiveMembers.ToList();

            
        }



        //NOW I WANT TO DO A SEARCH BY NAME
        //[HttpGet]
        //public IActionResult Index(string Usersearch)
        //{
        //    ViewData["GetUserdetails"] = Usersearch;

        //    var userquery = from x in _db.Subcriptions select x;

        //    if (!string.IsNullOrEmpty(Usersearch))
        //    {

        //        userquery = userquery.Where(x => x.ApplicationUser.UserName.Contains(Usersearch)
        //         || x.ApplicationUser.Email.Contains(Usersearch));

        //    }





        //    return View(userquery.AsNoTracking().ToList());
        //}



        //public IActionResult Index()
        //{
        //    RecurringJob.AddOrUpdate<IMyEmailService>(emailsender => emailsender.Send(), Cron.Minutely);
        //    return Ok();
        //}
    }
}