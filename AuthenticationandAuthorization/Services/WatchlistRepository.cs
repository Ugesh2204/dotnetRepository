using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticationandAuthorization.Data;
using AuthenticationandAuthorization.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationandAuthorization.Services
{
    public class WatchlistRepository : IWatchlistRepository
    {
        private AppDbContext _context;
        public WatchlistRepository(AppDbContext context)
        {
            _context = context;
        }
        //if exist return true
        public bool CheckIfAlreadyExists(string userId, int petId)
        {
            //it return true if any pet parameter exist in the database otherwise it is false
            return _context.Watchlists.Any(w => w.UserId.Equals(userId) && w.PetId == petId);
        }

        public void Create(Watchlist watchlist)
        {
            _context.Watchlists.Add(watchlist);
            _context.SaveChanges();
        }

        public List<Watchlist> GetUserWatchlist(string userId)
        {
            return _context.Watchlists
                            .Include(w => w.Pet)
                            .Where(w => w.UserId.Equals(userId))
                            .ToList();
        }

        public Watchlist GetWatchlist(int Id)
        {
            return _context.Watchlists.FirstOrDefault(w => w.Id == Id);
        }

        public List<Watchlist> GetWatchlistFromPetId(int petId)
        {
            return _context.Watchlists.Where(w => w.PetId == petId).ToList();
        }

        public void Remove(Watchlist watchlist)
        {
            _context.Watchlists.Remove(watchlist);
            _context.SaveChanges();
        }
    }
}
