using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticationandAuthorization.Models;
using AuthenticationandAuthorization.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationandAuthorization.Controllers
{
    public class AdministrationController : Controller
    {
        UserManager<ApplicationUser> userManager;

        RoleManager<IdentityRole> roleManager;

        public AdministrationController(UserManager<ApplicationUser> _userManager, RoleManager<IdentityRole> _roleManager)
        {
            userManager = _userManager;
            roleManager = _roleManager;
        }


        //1. we need to create a CreateRoleview model to add role to AspNetrole

        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                //if model state is valid we want to create a role object
                //and populate the property inside this object
                IdentityRole identityRole = new IdentityRole
                {
                    Name = model.RoleName
                };

                IdentityResult result = await roleManager.CreateAsync(identityRole);

                if (result.Succeeded)
                {
                    return RedirectToAction("ListRoles", "Administration");
                }

               //if model state is not valide then will show the erro
               foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(model);
        }

        //Get list of role

        [HttpGet]
        public IActionResult ListRoles()
        {
            var roles = roleManager.Roles;
            return View(roles);
        }


        //Edit role

        [HttpGet]
        public async Task<IActionResult> EditRole (string id)
        {
            //find this id with roleManager

           var role = await roleManager.FindByIdAsync(id);
            //if null we do not foun the id in the database
            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {id} cannot be  found";
                return View("NotFound");
            }

            //Let edit and instance of EditRoleViewModel

            var model = new EditRoleViewModel
            {
               Id = role.Id,
               RoleName = role.Name
               //In the model we all have this users property
               //Why we include this users property?
               //In addition to id and role name we also want to display the name of all user name
               //that belong to a particular role
            };

            //we want to retrive all the users in the database
            //so we are going to loop to user to see if the above role belong to that user

            foreach(var user in userManager.Users)
            {
                //This line will return truve if the user is the same that we want to edit
                //suppose we are editing a user with payroll it shoul say pay else will be false
               if( await userManager.IsInRoleAsync(user, role.Name))
                {
                    //if true we will add the user to model above which contain the users
                    model.Users.Add(user.UserName);
                }
            }


            return View(model);
        }



        [HttpPost]
        public async Task<IActionResult> EditRole(EditRoleViewModel model)
        {
            //find this id the database
            var role = await roleManager.FindByIdAsync(model.Id);

            //if null we do not foun the id in the database
            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {model.Id} cannot be  found";
                return View("NotFound");
            }
            else
            {
                role.Name = (model.RoleName);
                var result = await roleManager.UpdateAsync(role);

                if (result.Succeeded)
                {
                    return RedirectToAction("ListRoles");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View(model);
            }
        }
           
            //User part

            [HttpGet]
            public async Task<IActionResult> EditUsersInRole(string roleId)
            {
                //we are going to store roleId in the viewbag so that we can acess it th view

                ViewBag.roleId = roleId;
                var role = await roleManager.FindByIdAsync(roleId);
                if(role == null)
                {
                    ViewBag.ErrorMessage = $"Role with Id = {roleId} cannot be found";
                    return View("NotFound");
                }

            //we want a list of viewmodel object
            var model = new List<UserRoleViewModel>();

            // usermanger will give us a list of user
            //so we are looping throught each user for each user we want to create an instance 
            //of userrole view model

                foreach(var user in userManager.Users)
                {
                    //foreeach user we want to create an instance of UserRoleViewModel
                    // i am getting the Id fron user table and binding the id and userName to UserRoleView Model
                    //with the we will able to display the id and name of users in the view cshtml

                    var userRoleViewModel = new UserRoleViewModel
                    {
                        UserId = user.Id,
                        UserName = user.UserName
                    };

                    //wa also need to poupulation the checkbox boolean property if the user is already a member of a give role
                    //To check if a user is a member IsInRoleAsync service

                    if(await userManager.IsInRoleAsync(user, role.Name))
                    {
                        //si ena role r li checkbox pou checked sa v dir property UserRoleViewModel
                        // public bool IsSelected {get;set}; pou truve
                        userRoleViewModel.IsSelected = true;
                    }

                    else
                    {
                        //else we set it to false
                        userRoleViewModel.IsSelected = false;

                    }


                    //now we add the userRoleViewModel to the list model
                    //Notice we are adding in the viewmodel not in the database table
                    model.Add(userRoleViewModel);
                }

                return View(model);
          
            }


        //update Edit
        //Here we want to get a list of user from the form
        [HttpPost]
        public async Task<IActionResult> EditUsersInRole(List<UserRoleViewModel> model, string roleId)
        {
            //using role id let try to retrive the respect role from the database
            var role = await roleManager.FindByIdAsync(roleId);
            if(role== null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {roleId} cannot be found";
                return View("NotFound");
            }

            //we use a for loop to loop in model parameter

            for(int i= 0; i< model.Count; i++)
            {
                //find the user id we get it from the model parameter
                var user = await userManager.FindByIdAsync(model[i].UserId);

                IdentityResult result = null;

                //what does it mean when IsSelected is true
                // when the check box is checked
                //we need to check if user is in role name
                //if a user is selected and he is NOT already a member of this given menthod
                //only then call AddToRoleAsync method
                if (model[i].IsSelected && !(await userManager.IsInRoleAsync(user,role.Name)))
                {
                    //we store it in the result variable above result = null
                    result = await userManager.AddToRoleAsync(user, role.Name);
                }

                //so if the user is not selected if he is already a member of the given role.we want to 
                //remove from the role 
                else if (!model[i].IsSelected && (await userManager.IsInRoleAsync(user, role.Name)))
                {
                    result = await userManager.RemoveFromRoleAsync(user, role.Name);
                }
                else
                {
                    continue;
                }

                if (result.Succeeded)
                {
                    //we want to check if the loop variable I less that model .Count -1
                    // if this espression is true then that mean we have more userroleViewModel object
                    //in the model parameter that we want to process. So we use the continue key word
                    //else we have reach the end of the loop

                    if (i < (model.Count - 1))

                        continue;
                    else
                        //so we return to the EditRole Action passing the role id
                        return RedirectToAction("EditRole", new { Id = roleId });



                }
            }

            return RedirectToAction("EditRole", new { Id = roleId });
        }

    }
}