﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationandAuthorization.Models
{
    public class Pet
    {
        [Key]
        public int Id { get; set; }

        [Required]
        //[MinLength(3, ErrorMessage = "{0} must be greater or equal to {1} characters in length.")]
        //[Remote(action: "VerifyName", controller: "Pet")]
        public string Name { get; set; }

        [Required]
        [Range(0, 5, ErrorMessage = "{0} must be between {1} and {2} years")]
        public int Age { get; set; }

        [Required]
        public string Color { get; set; }
        public bool IsSelling { get; set; } = false;
        public ApplicationUser User { get; set; }
        public string UserId { get; set; }
        public List<Watchlist> Watchlists { get; set; }
    }
}
