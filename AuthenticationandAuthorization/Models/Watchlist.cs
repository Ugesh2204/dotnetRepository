using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationandAuthorization.Models
{
    public class Watchlist
    {
        [Key]
        public int Id { get; set; }
        public int PetId { get; set; }
        public Pet Pet { get; set; }
        public string UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
