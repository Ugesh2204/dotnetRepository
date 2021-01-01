using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace AuthenticationandAuthorization.HangFire_service
{
    public class MyEmailService : IMyEmailService
    {

        public void SendEmail(string ToAddress, string Subject, string Body)
        {
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                UseDefaultCredentials = true,
                Credentials = new NetworkCredential("ugesh.roopchand22@gmail.com", "Ugmy2285!"),
                EnableSsl = true
            };
            client.Send("info@GymPro.com", ToAddress, Subject, Body);
        }
    }
}
