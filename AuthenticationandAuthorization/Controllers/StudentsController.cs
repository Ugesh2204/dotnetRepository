using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AuthenticationandAuthorization.Data;
using AuthenticationandAuthorization.Models;
using AuthenticationandAuthorization.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationandAuthorization.Controllers
{
    
    public class Students : Controller
    {
        AppDbContext db;
        IHostingEnvironment hostingEnvironment;
        public Students(AppDbContext _db, IHostingEnvironment hostingEnvironment)
        {
            db = _db;
            this.hostingEnvironment = hostingEnvironment;
        }

        [Authorize(Roles = "Admin,User")]
        public IActionResult Index()
        {

            var Student = db.Students.ToList();

            return View(Student);
        }


        //Here only Admin can create
        [HttpGet]
        [Authorize(Roles = "Admin")]
        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create( StudentViewModel model)
        {
            //we want to check on the photo model property is not null
            string uniqueFileName = null;

            if(model.Photo != null)
            {
                //To get the path of the www folder we are going to use the IHOSTING ENVIROMENT
                string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "Images");
                //to prevent upload image twice we use guid
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;

               string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                model.Photo.CopyTo(new FileStream(filePath, FileMode.Create));

            }

            Student newstudent = new Student
            {
                Name = model.Name,
                Email = model.Email,
                ImageUrl = uniqueFileName
            };

            db.Add(newstudent);
            db.SaveChanges();

            return RedirectToAction("Index", "Students");
        }



     


    }
}