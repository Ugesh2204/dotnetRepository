using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationandAuthorization.Hubs
{
    public class WeatherHub : Hub
    {

        public async Task BroadcastFromClient(string message)
        {
            //sending back to our client
            await Clients.All.SendAsync("Broadcast", message);
        }
    }
}
