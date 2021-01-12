using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationandAuthorization.Models
{
    public class Watchlist
    {
        //Relation between applicationuser and Pet
        //So AppliUser can have more that 1 pet thier wtch list
        // And each pet in the watch list belong to a particular appUser
        //1:M
        [Key]
        public int Id { get; set; }
        public int PetId { get; set; }
        //the pet in the watchlist belong to a particular pet
        public Pet Pet { get; set; }
        public string UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
