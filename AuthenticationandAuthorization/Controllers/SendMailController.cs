using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using AuthenticationandAuthorization.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationandAuthorization.Controllers
{
    public class SendMailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Gmail em)
        {

            string to = em.To;
            string subject = em.Subject;
            string body = em.Body;

            MailMessage mm = new MailMessage();
            mm.To.Add(to);
            mm.Subject = subject;
            mm.Body = body;

            //I want to send email from this adress
            mm.From = new MailAddress("ugesh.roopchand22@gmail.com");
            mm.IsBodyHtml = false;

            //Smtp client
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.UseDefaultCredentials = true;
            smtp.EnableSsl = true;

            smtp.Credentials = new System.Net.NetworkCredential("ugesh.roopchand22@gmail.com", "Ugesh2285!");

            //sent mail with mm object
            smtp.Send(mm);

            ViewBag.msg = "The Mail has been sent to " + em.To + "Successfully...!";

            return View();
        }
    }
}