using AuthenticationandAuthorization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationandAuthorization.Services
{
   
        public interface IWatchlistRepository
        {
            Watchlist GetWatchlist(int Id);
            void Create(Watchlist watchlist);
            List<Watchlist> GetUserWatchlist(string userId);
            void Remove(Watchlist watchlist);
            bool CheckIfAlreadyExists(string userId, int petId);
            List<Watchlist> GetWatchlistFromPetId(int petId);
        }
    
}
