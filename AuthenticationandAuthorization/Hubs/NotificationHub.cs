using AuthenticationandAuthorization.Data;
using AuthenticationandAuthorization.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationandAuthorization.Hubs
{
    public class NotificationHub: Hub
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly AppDbContext _db;

        public NotificationHub(AppDbContext db, UserManager<ApplicationUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }


        public async Task BroadcastFromClientOne(string message)
        {
            try
            {
                //get current user
                var currentUser = await _userManager.GetUserAsync(Context.User);
                //Create an intance of our new message model

                Message m = new Message()
                {
                    MessageBody = message,
                    MessageDtTm = DateTime.Now,
                    FromUser = currentUser
                };

                //add message 

                _db.Messages.Add(m);
                await _db.SaveChangesAsync();

                //Now we  will broadcast this message to all user
                //The javascript has to take this model and set the property in the UI
                await Clients.All.SendAsync(
                    "Broadcast",
                    new
                    {
                        messageBody = m.MessageBody,
                        fromUser = currentUser.Email,
                        MessageDtTm = m.MessageDtTm.ToString(
                            "hh:mm tt MMM dd", CultureInfo.InvariantCulture

                        )
                    });


            }
            catch (Exception ex)
            {
                await Clients.Caller.SendAsync("HubErrors", new { error = ex.Message });
            }


        }



    }
}
