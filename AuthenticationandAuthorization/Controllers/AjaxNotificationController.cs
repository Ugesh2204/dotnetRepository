using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticationandAuthorization.Data;
using AuthenticationandAuthorization.Models;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationandAuthorization.Controllers
{
    public class AjaxNotificationController : Controller
    {
        AppDbContext db;

        public AjaxNotificationController(AppDbContext _db)
        {
            db = _db;
        }

  


        public IActionResult Index()
        {
            return View();
        }


        public IActionResult MessageTable()
        {
            var GetAll = db.Messages.ToList();
            return View(GetAll);


        }

        //We return a PartailViewResult
        //So what is partial view. Is a part of a view 
        //that can made resusable or use it whereever i want

        //public PartialViewResult MessageTable()
        //{
        //    var GetAll = db.Messages.ToList();
        //    return PartialView("pv_MessageTable");
        //}





        [HttpGet]
        public IActionResult CreateMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateMessage(Message message)
        {

            db.Add(message);
            db.SaveChanges();


            return View(message);
        }

        [HttpGet]
        public IActionResult DeleteMessage(int id)
        {
            // db.Messages.fFind(id);
            var message = db.Messages.Where(x => x.MessageId == id).FirstOrDefault();

            db.Remove<Message>(message);
            db.SaveChanges();
            return RedirectToAction("MessageTable");
        }

        [HttpGet]
        public IActionResult AjaxDelete(int id)
        {
            // db.Messages.fFind(id);
            var message = db.Messages.Where(x => x.MessageId == id).FirstOrDefault();

            db.Remove<Message>(message);
            db.SaveChanges();
            return RedirectToAction("MessageTable");
        }

    }
}