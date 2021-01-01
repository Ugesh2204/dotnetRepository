using AuthenticationandAuthorization.Data;
using AuthenticationandAuthorization.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationandAuthorization.Hubs
{
    public class ChatHub:Hub
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly AppDbContext _db;


        public ChatHub(AppDbContext db,UserManager<ApplicationUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }


        //we will broadcast a message to all our client

        public async Task BroadcastFromClient(string message)
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
                        MessageDtTm =m.MessageDtTm.ToString(
                            "hh:mm tt MMM dd", CultureInfo.InvariantCulture
                            
                        )
                    });

            }
            catch(Exception ex)
            {
                //sent any error to client caller
                await Clients.Caller.SendAsync("HubErrors", new { error = ex.Message });
            }

        }




        //connecting and disconnecting method override

        //when a user connect we just broadcast that a user is connected
        //every time a user connect we append it to our UI div
        //ListnerEvent is UserConnected

        public override async Task OnConnectedAsync()
        {
            await Clients.All.SendAsync(
                "UserConnected",
                new
                {
                    //everytime a user connect we get hold of the connection id
                    connectionId = Context.ConnectionId,
                    connectionDtTm = DateTime.Now,
                    MessageDtTm =DateTime.Now.ToString(
                            "hh:mm tt MMM dd", CultureInfo.InvariantCulture

                        )
                });
        }



        //ondisconnected event sign off
        public override async Task OnDisconnectedAsync(Exception ex)
        {
            await Clients.All.SendAsync("UserDisconnected",
                $"user disconnected, ConnectionId: { Context.ConnectionId}");
  
        }



    }
}
