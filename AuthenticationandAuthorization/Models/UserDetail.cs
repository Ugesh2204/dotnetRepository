using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationandAuthorization.Models
{
    public class UserDetail
    {
        public int UserdetailId { get; set; }
        public string UserName { get; set; }
        public string UserImageUrl { get; set; }


        public ApplicationUser ApplicationUser { get; set; }
    }
}
