using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeEF.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstMidName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool ActiveEmp { get; set; }
        public bool IsManager { get; set; }
         public string Title { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        // managerid will just be the employee id for the manager
        public int ManagerEmplID { get; set; }




    }
}