using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticationandAuthorization.Models;
using AuthenticationandAuthorization.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationandAuthorization.Controllers
{
    [Authorize(Roles = "Super Admin")]
    public class AccountManagerController : Controller
    {

       
        UserManager<ApplicationUser> userManager;

        RoleManager<IdentityRole> roleManager;


        //And we get this object from dependency injection
        public AccountManagerController(UserManager<ApplicationUser> _userManager, RoleManager<IdentityRole> _roleManager)
        {
            userManager = _userManager;

            //Here i get signInManager object
            roleManager = _roleManager;

        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AssignRole()
        {
            //Get all the Register users
            var users = userManager.Users.ToList();

            //Next i need all the roles
            var roles = roleManager.Roles.ToList();

            //Getting all the Role from IDENTITYRole that have all the filed
            // i am stroing all the role in the ListRoles
            List<string> listRoles = new List<string>();
            foreach (var item in roles)
            {
                listRoles.Add(item.Name);
            }

            //Now i have to create a list of our view model
            //and i need to fill this list

            List<AssignRoleViewModel> list = new List<AssignRoleViewModel>();

            foreach (var item in users)
            {
                //we create an object of AssignRoleViewModel
                AssignRoleViewModel model = new AssignRoleViewModel();
                // These 3 we cab get easily from users table
                model.UserId = item.Id;
                model.UserName = item.UserName;
                model.Email = item.Email;
                //
                //I want to know whether this user has some role or not
                //So i want to get that role name
                // If the user have already some role this count will not b equal to zero
                //so we are trying to get the role name 
                //if not we assign it to null tenary opertator
                //condition_expression ? first_expression : second_expression; 

                //So this line of code will check in the datbase whether this current user has a role or not and 
                //if it has a role it will get the role name 
                model.RoleName =  userManager.GetRolesAsync(item).Result.Count != 0 ? userManager.GetRolesAsync(item).Result[0] : "";
                model.Roles = listRoles;
                list.Add(model);
            }


            //passing our list of  AssignRoleViewModel
            return View(list);
        }


        [HttpPost]
        public async Task<IActionResult> AssignRole(string UserId, string RoleName)
        {

            //This is the standard rule you have to follow ModelState.Isvalide

            //if (ModelState.IsValid) { 
            //Get the user

            var user =  userManager.FindByIdAsync(UserId).Result;

            //var role = roleManager.FindByIdAsync(UserId).Result;

            //if(role != null)
            //{
            //    var result =  roleManager.DeleteAsync(role);
            //}

            var roles = roleManager.Roles.ToList();

            List<string> listRoles = new List<string>();
            foreach (var item in roles)
            {
                listRoles.Add(item.Name);
            }

            //string output = string.Join(Environment.NewLine, listRoles.ToArray());


            //I need to remove the role awith user and list of role



            var ResultRemove = await userManager.RemoveFromRolesAsync(user, listRoles);

            //Assign the role to the user with AddRoleAsync
            var Result = await userManager.AddToRoleAsync(user, RoleName);

            return RedirectToAction("AssignRole");

            //}

            //return View();

          
        }

    }
}