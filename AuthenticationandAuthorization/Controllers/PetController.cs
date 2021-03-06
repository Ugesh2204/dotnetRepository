﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticationandAuthorization.Data;
using AuthenticationandAuthorization.Models;
using AuthenticationandAuthorization.Services;
using ClientNotifications;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using static ClientNotifications.Helpers.NotificationHelper;

namespace AuthenticationandAuthorization.Controllers
{
    public class PetController : Controller
    {

        //private readonly UserManager<ApplicationUser> _userManager;

        AppDbContext _db;
        private IPetRepository _petRepository;
        private UserManager<ApplicationUser> _userManger;
        //Inject sweet alert 
        private IClientNotification _clientNotification;
        //Inject notification
        private INotificationRepository _notificationRepository;


        public PetController(AppDbContext db, 
                            IClientNotification clientNotification, 
                             UserManager<ApplicationUser> userManager,
                             INotificationRepository notificationRepository)
        {
           _db = db;
            //_userManager = userManager;
            _petRepository = new PetRepository(_db);
            _clientNotification = clientNotification;
            _userManger = userManager;
            _notificationRepository = notificationRepository;

        }

        public IActionResult Index(string search = null)
        {
            //if (!string.IsNullOrEmpty(search))
            //{
            //    var foundPets = _petRepository.SearchPets(search);
            //    return View(foundPets);
            //}

            var pets = _petRepository.GetAllPets();
            return View(pets);
           
        }

        [Authorize]
        public IActionResult MyPets()
        {
            var userId = _userManger.GetUserId(HttpContext.User);
            var pets = _petRepository.GetPetByUserId(userId);
            return View(pets);
        }

        public IActionResult Details(int id)
        {
            var pet = _petRepository.GetSinglePet(id);
            return View(pet);
        }

        [HttpGet]
        public IActionResult New()
        {
            ViewBag.IsEditMode = "false";
            var pet = new Pet();
            return View(pet);
        }



        [HttpPost]
        public IActionResult New(Pet pet, string IsEditMode)
        {

            //To handle Exception we use try catch block to give 
            //more specfic error about what happen

            try
            {
                //throw new UnauthorizedAccessException();

                if (IsEditMode.Equals("false"))
                {
                    _petRepository.Create(pet);

                    _clientNotification.AddSweetNotification("Success",
                                "Your Pet is Created",
                                NotificationType.success);

                }

                else
                {
                    _petRepository.Edit(pet);

                    _clientNotification.AddSweetNotification("Success",
                               "Your Pet has been edited",
                               NotificationType.success);

                }

               

                return RedirectToAction(nameof(Index));

            } catch (Exception)
            {
                _clientNotification.AddSweetNotification("Error",
                              "Your could be created",
                              NotificationType.error);

                return RedirectToAction(nameof(Index));
            }
           
        }


        [HttpGet]
        public IActionResult Edit(int Id)
        {
            try {
                ViewBag.IsEditMode = "true";
                var pet = _petRepository.GetSinglePet(Id);
                return View("New", pet);
            }
            catch (Exception)
            {
                return Content("Could not find the pet");
            }

           

        }

        public IActionResult Delete(int Id)
        {
            try
            {
                var pet = _petRepository.GetSinglePet(Id);
                _petRepository.Delete(pet);

                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
           
        }


        public IActionResult ToggleSelling(int id)
        {
            try
            {
                //form seling to not selling

                var pet = _petRepository.GetSinglePet(id);

                //change pet status

                pet.IsSelling = !pet.IsSelling;

                _petRepository.Edit(pet);

                //send notification
                var username = _userManger.GetUserName(HttpContext.User);
                var status = "";
                if (pet.IsSelling)
                    status = "Selling";
                else
                    status = "Not Selling";
                var notification = new Notification
                {
                    Text = $"The {username} is {status} their pet"

                };
                _notificationRepository.Create(notification, pet.Id);
                //end notification
            }

            catch (Exception)
            {
                return Content("Error oocurred + ex.ToString()");
            }

                return RedirectToAction(nameof(Details),new { id = id });
        }



    }
}