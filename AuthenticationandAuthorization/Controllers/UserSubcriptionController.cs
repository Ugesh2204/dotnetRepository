using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticationandAuthorization.Data;
using AuthenticationandAuthorization.Models;
using AuthenticationandAuthorization.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationandAuthorization.Controllers
{
    public class UserSubcriptionController : Controller
    {
        
            AppDbContext db;
            private readonly UserManager<ApplicationUser> _userManager;

            public UserSubcriptionController(AppDbContext _db, UserManager<ApplicationUser> userManager)
            {
                db = _db;
               _userManager = userManager;
            }


            public IActionResult Index()
            {
                //2.The SelectList() will take 3 parameter
                //2.1st GetMembershipLists() method 2nd the MembershipId,MembershipType
                ViewBag.MembershipList = new SelectList(GetMembershipLists(), "MembershipId", "MembershipType");
            return View();
            }

            //1.Get the list with a simple method
            public List<Membership> GetMembershipLists()
            {
                return db.Memberships.ToList();
            }

            //3. Create getprice list IActionResult
            public IActionResult GetMPriceList(int Mid)
            {
                //Here we will do a query Mid bisin equal a Membershipid
                var Selectprice = db.Membership_Prices.Where(x => x.MembershipId == Mid).ToList();
                //Here i am stroring price list in a view bag and pass the 3 parameter 
                //"PriceId", "Price" are from price table
                ViewBag.MpriceList = new SelectList(Selectprice, "PriceId", "Price");

                //Here we are return a patial view 
                //In the partail view i will select membership_price as model
                //To create a partial view go to the share folder add a view  and name it

                return PartialView("_DisplayMembershipPricePartial");
            }




           //Add subcription 

        public IActionResult AddSubcription(SubcriptionViewModel model)
        {

           // 1 Get the login User id
           var logInUserid = _userManager.GetUserId(HttpContext.User);

            //get the member name throught ID
            var membershipList = db.Memberships.ToList();
            var membershipName = membershipList.Where(x => x.MembershipId == model.MembershipId)
                                 .Select(x => x.MembershipType).SingleOrDefault();

            //get the price throught ID
            var priceList = db.Membership_Prices.ToList();
            var priceName = priceList.Where(x => x.PriceId == model.PriceId)
                            .Select(x => x.Price).SingleOrDefault();



            //add to sub table
            Subcription usersub = new Subcription();
            usersub.ApplicationUserId = logInUserid;
            usersub.MembershipId = model.MembershipId;
            usersub.MembershipName = membershipName;
            usersub.Amount = priceName;
            usersub.StartDate = model.Date;


            db.Add(usersub);
            db.SaveChanges();

            return RedirectToAction("UserSubcriptionDetails");

        }


        //Show  user Subcription detail


        public IActionResult UserSubcriptionDetails()
        {
            var logInUserid = _userManager.GetUserId(HttpContext.User);
            //var membershipDetail = db.Payments
            //                       .Include(x => x.Subcription)
            //                       .ToList();

            //var membershipDetail = db.Subcriptions.Where(x => x.ApplicationUserId == logInUserid)
            //                        .Include(x => x.Payments)
            //                        .ToList();


            var membershipDetail = db.Subcriptions.Where(x => x.ApplicationUserId == logInUserid)
                                   .ToList();

            return View(membershipDetail);
        }



    }
}