using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace AuthenticationandAuthorization.Services
{
    public static class EmailService
    {
        
        //ToAddress = to whom i want to sent the email
        //Subject = the subject of the email


    public static void Send(string ToAddress, string Subject, string Body)
    {
        var client = new SmtpClient("smtp.gmail.com", 587)
        {
           UseDefaultCredentials=true,
           Credentials = new NetworkCredential("ugesh.roopchand22@gmail.com", "Ugesh2285!"),
            EnableSsl = true
        };
        client.Send("info@manzoorthetrainer.com", ToAddress, Subject, Body);
    }
        

    }
}
