using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticationandAuthorization.Data;
using AuthenticationandAuthorization.Models;
using AuthenticationandAuthorization.Services;
using ClientNotifications;
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

        private IClientNotification _clientNotification;


        public PetController(AppDbContext db, IClientNotification clientNotification)
        {
           _db = db;
            //_userManager = userManager;
            _petRepository = new PetRepository(_db);
            _clientNotification = clientNotification;

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



    }
}