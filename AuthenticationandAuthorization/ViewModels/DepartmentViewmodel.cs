using AuthenticationandAuthorization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationandAuthorization.ViewModels
{
    public class DepartmentViewmodel
    {
        public IEnumerable<Employee> Employees { get; set; }

        public IEnumerable<Department> Departments { get; set; }


    }
}
