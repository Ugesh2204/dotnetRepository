using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticationandAuthorization.Data;
using AuthenticationandAuthorization.Models;
using AuthenticationandAuthorization.Services;
using AuthenticationandAuthorization.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AuthenticationandAuthorization.Controllers
{
    public class NewNotificationwithJsController : Controller
    {
        private AppDbContext _db;
        private IRapidNotification _rapidNotification;
        private UserManager<ApplicationUser> _userManager;
        public NewNotificationwithJsController(AppDbContext db,IRapidNotification rapidNotification, UserManager<ApplicationUser> userManager)
        {
            _db = db;
           _rapidNotification = rapidNotification;
            _userManager = userManager;
        }




        public IActionResult Index()
        {
            //2.The SelectList() will take 3 parameter
            //2.1st GetMembershipLists() method 2nd the MembershipId,MembershipType
            ViewBag.MembershipList = new SelectList(GetListOfUser(), "Id", "UserName");
            return View();
        }

        //1.Get the list with a simple method
        public List<ApplicationUser> GetListOfUser()
        {
            return _db.Users.ToList();
        }



        public IActionResult SentRapidMsg(NewMessageApplicationUser model)
        {

            NewMessage msg = new NewMessage();
            msg.MyUserId = model.ApplicationUserId;
            msg.Subject = model.NewMessage.Subject;
            msg.MessageText = model.NewMessage.MessageText;

            _rapidNotification.Create(msg);



            model.MessageId = msg.MessageId;
            model.ApplicationUserId = msg.MyUserId;
            _db.Add(model);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult GetNotification()
        {   
            //Get login UserId
            var userId = _userManager.GetUserId(HttpContext.User);
            var notification = _rapidNotification.GetUserNotifications(userId);
            return Ok(new { UserMessageNotif = notification, Count = notification.Count });
        }




        }
    }