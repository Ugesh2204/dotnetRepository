using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticationandAuthorization.Models;
using AuthenticationandAuthorization.Services;
using AuthenticationandAuthorization.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationandAuthorization.Controllers
{
    public class AccountController : Controller
    {   //for user Registration we are creating object of userManager
        UserManager<ApplicationUser> userManager;

        SignInManager<ApplicationUser> signInManager;


        //And we get this object from dependency injection
        public AccountController(UserManager<ApplicationUser> _userManager, SignInManager<ApplicationUser> _signInManager)
        {
            userManager = _userManager;
            //Here i get signInManager object
            signInManager = _signInManager;

        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
         {
            ApplicationUser user = new ApplicationUser()
            {
                UserName = model.UserName,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email
                
            };

            var result = await userManager.CreateAsync(user, model.Password);

            //Generate a confirmation email token
           
            //create link
            //The link is pointing to confirmEmail of Account controler
            //with 2 parameter userid id and token 
            //userid iam getting it from user and token from CONFIRMATION TOKEN
          


            //we test it with a text file so that we dont revile our password

           //System.IO.File.WriteAllText(@"C:\Users\Ugesh\Desktop\dotcore2020\Notes\Temp\ConfirmEmail.txt", confirmationLink);


            if (result.Succeeded)
            {
                string confirmationToken = await userManager.GenerateEmailConfirmationTokenAsync(user);
                string confirmationLink = Url.Action("ConfirmEmail", "Account", new { userid = user.Id, token = confirmationToken }, Request.Scheme);
                EmailService.Send(user.Email, "Confirm Your Email", $"Please Confirm your Email Address by clicking this link:  <a href='{confirmationLink}'>link</a/>");


                //return RedirectToAction("Login","Account");
                ViewBag.Msg = "Confirmation link has been send to the above entered email.<br> Please check your email, " +
                            "conifrm it by clicking the link provided and get access to your account"; 

                    
            }
            else
            {
                ViewBag.Msg = "ERORR SENT EMAIL FAIL. Please ensure that you have a Gmail Account ";
            }

            return View();
        }


        [HttpGet]
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            var user = await userManager.FindByIdAsync(userId);
            var result = await userManager.ConfirmEmailAsync(user, token);
            if (result.Succeeded)
            {
                ViewBag.Msg = "Email confirmation Succeeded!";
            }
            else
            {
                ViewBag.Msg = "Email confirmation Failed!";
            }

            return View();
        }




        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        //LoginViewModel object
        [HttpPost]
        public  async Task<IActionResult>Login(LoginViewModel model)
        {
            //It is expecting identity user, password,bool isPersistent that is remember me and lockoutOnFailure is set by default 5 times
        var Result = await signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe,true);

            //nOW I WILL CHECK THE RESULT WITH SUCEEDED

            if (Result.Succeeded)
            {
                return RedirectToAction("Index", "Home");

                //If user confirm password i am givin access
                //find user by name
                //var user = await userManager.FindByNameAsync(model.UserName);
                ////if email is confirm give access
                //if (user.EmailConfirmed)
                //{
                //    return RedirectToAction("Index", "Home");
                //}
                //else
                //{
                //    //sign out the user
                //    await signInManager.SignOutAsync();

                //}

            }

              
            return View();
        }



        //Reset password

            [HttpGet]
            public IActionResult ForgotPassword()
            {
             return View();
            }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel model)
        {


            //we have user manager object
            //with the usermanger object we are trying to that user by email address
            //and we are getting the email from model
            var user = await userManager.FindByEmailAsync(model.UserEmail);
            //After finding the user we are trying to generate token
            var resetToken = await userManager.GeneratePasswordResetTokenAsync(user);

            //Now i need to make a link for reset 

            string resetLink = Url.Action("ResetPassword", "Account", new { userid = user.Id, token = resetToken }, protocol: HttpContext.Request.Scheme);
            EmailService.Send(user.Email, "Reset your password", $"Please click on the link to Reset your Password:  <a href='{resetLink}'>link</a/>");
            //create a new text file reset password
            //System.IO.File.WriteAllText(@"C:\Users\Ugesh\Desktop\dotcore2020\Notes\Temp\ResetPassword.txt", resetLink);
            //var callbackurl = .ResetpasswordCallbackLink(user.id, code,Request.Scheme);
            //Once they get the reset link we are goin to display a message
            ViewBag.Msg = "Reset Password Link Has Been Emailed";
            return View();
        }


        [HttpGet]
        public IActionResult ResetPassword(string userId, string token)
        {
            //Here i create the object of ResetPasswordViewModel
            var obj = new ResetPasswordViewModel()
            {
                UserId = userId,
                Token = token
            };


            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult>ResetPassword(ResetPasswordViewModel model)
        {
            //find the user first
            var user = await userManager.FindByIdAsync(model.UserId);
            //Reset password will take 3 parameters
            var result = await userManager.ResetPasswordAsync(user, model.Token, model.Password);

            if (result.Succeeded)
            {
                //if succeed you can redirect to login page
                ViewBag.Msg = "Password Reset Succeded!";
            }
            else
            {
                ViewBag.Msg = "Password Reset Failed!";
            }

            return View();
        }



        //Logout

        [HttpGet]
        public async Task <IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login","Account");
        }


        //Access denied action

        [HttpGet]
        public IActionResult AccessDenied()
        {
            return View();
        }

    }
}