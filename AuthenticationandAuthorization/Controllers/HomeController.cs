using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticationandAuthorization.Hubs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace AuthenticationandAuthorization.Controllers
{
    public class HomeController : Controller
    {
        //addSignalr
        private readonly IHubContext<WeatherHub> _weatherHubContext;

        public HomeController(IHubContext<WeatherHub> weatherHubContex)
        {
            _weatherHubContext = weatherHubContex;
        }
        public IActionResult Index()
        {
            return View();
        }


        //what i want here is when someone land on our 
        //privacy page i want to broadcast some msg
        public async Task<IActionResult> Privacy()
        {
            await _weatherHubContext
                .Clients
                .All
                .SendAsync("Broadcast", $"Privacy page visited at: {DateTime.Now}");
            return View();
        }
    }
}