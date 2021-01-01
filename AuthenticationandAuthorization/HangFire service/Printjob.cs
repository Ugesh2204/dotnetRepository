using AuthenticationandAuthorization.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationandAuthorization.HangFire_service
{
    public class Printjob : IPrintjob
    {

      
        public void Print()
        {
            Console.WriteLine($"Hangfrie recuring from Class job");

        }
    }
}
