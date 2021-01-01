using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationandAuthorization.Models
{
    public class SingleDetails
    {

        [Key]
        public int? UserlogInId { get; set; }

        public string UserName { get; set; } 

        public string ImagePhoto { get; set; }
        
        

        [ForeignKey("ApplicationUserId")]
        public string ApplicationUserId { get; set; }
       
        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}
