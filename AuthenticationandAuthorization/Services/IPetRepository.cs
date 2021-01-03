using AuthenticationandAuthorization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationandAuthorization.Services
{
    public interface IPetRepository
    {
        void Create(Pet pet);
        void Edit(Pet pet);
        Pet GetSinglePet(int id);
        void Delete(Pet pet);
        List<Pet> GetAllPets();
        bool VerifyName(string name);
        List<Pet> SearchPets(string search);
        List<Pet> GetPetByUserId(string userId);
    }
}
