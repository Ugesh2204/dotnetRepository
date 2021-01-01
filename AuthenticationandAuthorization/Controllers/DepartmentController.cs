using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticationandAuthorization.Data;
using AuthenticationandAuthorization.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationandAuthorization.Controllers
{
    public class DepartmentController : Controller
    {
        AppDbContext db;

        public DepartmentController(AppDbContext _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {




            //var depemployee = db.Employees
            //                    .Include(d => d.Department);
                               
            return View();
        }
    }
}