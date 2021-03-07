using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticationandAuthorization.Models;
using AuthenticationandAuthorization.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationandAuthorization.Controllers
{
    [Authorize]
    public class NotificationController : Controller
    {
        private INotificationRepository _notificationRepository;
        private UserManager<ApplicationUser> _userManager;

        public NotificationController(INotificationRepository notificationRepository,
                                        UserManager<ApplicationUser> userManager)
        {
            _notificationRepository = notificationRepository;
            _userManager = userManager;

        }
        public IActionResult GetNotification()
        {
            //This method get the notification of the user and return that notification
            //to caller of this method and we get the count of the notification the user
            //has and what the notification
            var userId = _userManager.GetUserId(HttpContext.User);
            var notification = _notificationRepository.GetUserNotifications(userId);
            return Ok(new { UserNotification = notification, Count = notification.Count });
        }


        //Method to read the status of the notification

        public IActionResult ReadNotification(int notificationId)
        {
            _notificationRepository.ReadNotification(notificationId);

            return Ok();
        }
    }
}