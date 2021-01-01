using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationandAuthorization.ViewModels
{
    public class Gmail
    {
        public int id { get; set; }
        public string To { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }
    }
}
