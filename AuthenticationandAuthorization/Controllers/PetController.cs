using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticationandAuthorization.Data;
using AuthenticationandAuthorization.Models;
using AuthenticationandAuthorization.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationandAuthorization.Controllers
{
    public class PetController : Controller
    {

        //private readonly UserManager<ApplicationUser> _userManager;

        AppDbContext _db;
        private IPetRepository _petRepository;


        public PetController(AppDbContext db)
        {
           _db = db;
            //_userManager = userManager;
            _petRepository = new PetRepository(_db);

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
            if (IsEditMode.Equals("false"))

                _petRepository.Create(pet);

            else
                _petRepository.Edit(pet);

            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public IActionResult Edit(int Id)
        {
            ViewBag.IsEditMode = "true";
            var pet = _petRepository.GetSinglePet(Id);
            return View("New", pet);

        }

        public IActionResult Delete(int Id)
        {
            var pet = _petRepository.GetSinglePet(Id);
            _petRepository.Delete(pet);
            return RedirectToAction(nameof(Index));
        }



    }
}