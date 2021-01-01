using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AuthenticationandAuthorization.Data;
using AuthenticationandAuthorization.Models;
using AuthenticationandAuthorization.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationandAuthorization.Controllers
{
    [Authorize]
    public class SingleDetailController : Controller
    {
       
        private readonly UserManager<ApplicationUser> _userManager;

        AppDbContext _db;
        IHostingEnvironment hostingEnvironment;

        public SingleDetailController(AppDbContext db, UserManager<ApplicationUser> userManager, IHostingEnvironment hostingEnvironment)
        {
            _db = db;
           _userManager =  userManager;
            this.hostingEnvironment = hostingEnvironment;
        }



        public IActionResult Index()
        {
            var logInUserid = _userManager.GetUserId(HttpContext.User);

            var finduser = _db.SingleDetails.Where(x => x.ApplicationUserId == logInUserid).FirstOrDefault();

            if(finduser == null)
            {
                return RedirectToAction("Create", "SingleDetail");
            }
            else
            {
                
                var userdetail = _db.SingleDetails.Include(a => a.ApplicationUser)
                          .FirstOrDefault(x => x.ApplicationUser.Id == logInUserid);

                return View(userdetail);

            }




            //FirSt technique to get lOGINuSER ID
            //var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            //var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            //var user = _db.SingleDetails.Where(c => c.ApplicationUserId == claim.Value).SingleOrDefault();


            //SECOND TECHNIQUE TO GET LOGIN USER ID 
           


            //var test = _userManager.Users.Where(s => s.Id == userid).FirstOrDefault();

            //DetailViewModel model = new DetailViewModel();


            //    model.Id = test.Id;

            //    model.email = test.Email;
            //    model.email = test.UserName;





            //model.Id = userid;

            //SingleDetails model = new SingleDetails();

            //model.ApplicationUserId = userid;

            //_db.SaveChanges();






            


           

            
        }



        [HttpGet]
        public IActionResult Create()
        {
            //I need to sent the login id in this model

            var logInUserid = _userManager.GetUserId(HttpContext.User);

            SingleDetailViewModel model = new SingleDetailViewModel();

            model.Id = logInUserid;

            return View(model);
        }


        [HttpPost]
        public IActionResult Create(SingleDetailViewModel model)
        {

            //we want to check on the photo model property is not null
            string uniqueFileName = null;

            if (model.Photo != null)
            {
                //To get the path of the www folder we are going to use the IHOSTING ENVIROMENT

                string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "Images");

                //to prevent upload image twice we use guid
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;

                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                model.Photo.CopyTo(new FileStream(filePath, FileMode.Create));

            }



            SingleDetails user = new SingleDetails();
            user.ApplicationUserId = model.Id;
            user.UserName = model.UserName;
            user.ImagePhoto = uniqueFileName;


            _db.Add(user);
            _db.SaveChanges();

            return RedirectToAction("Index", "SingleDetail");

        }



        [HttpGet]
        public IActionResult Edit(string id)
        {


          


            var user = _db.SingleDetails.Where(x => x.ApplicationUserId == id ).FirstOrDefault();

            SingleDetailViewModel model = new SingleDetailViewModel();
            //We attach back the data to the view model 
            model.Id = user.ApplicationUserId;
            model.UserName = user.UserName;


            //var userid = _userManager.GetUserId(HttpContext.User);

            //var user = _db.SingleDetails.Where(s => s.ApplicationUserId == userid).SingleOrDefault();

            return View(model);
        }



        [HttpPost]
        public IActionResult Edit( string id, SingleDetailViewModel model)
        {
            //we want to check on the photo model property is not null
            string uniqueFileName = null;

            if (model.Photo != null)
            {
                //To get the path of the www folder we are going to use the IHOSTING ENVIROMENT

                string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "Images");

                //to prevent upload image twice we use guid
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;

                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                model.Photo.CopyTo(new FileStream(filePath, FileMode.Create));

            }

            var user = _db.SingleDetails.Where(x => x.ApplicationUserId == id).FirstOrDefault();
            //We need to bind the changes back to SingleDetail



            user.UserName = model.UserName;
            user.ImagePhoto = uniqueFileName;



            _db.SaveChanges();
            return RedirectToAction("Index", "SingleDetail");

           
        }


        public IActionResult Photo(string id)
        {

            //var userid = _userManager.GetUserId(HttpContext.User);

            //var user = _db.SingleDetails.Where(s => s.ApplicationUserId == userid).FirstOrDefault();

            //use view bag

            SingleDetailViewModel model = new SingleDetailViewModel();


            var user = _db.SingleDetails.Where(x => x.ApplicationUserId == id).FirstOrDefault();

            model.Id = user.ApplicationUserId;
            model.UserName = user.UserName;


            return View(user.ImagePhoto);
        }




    }
}