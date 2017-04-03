using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EmployeeEF.Models;


namespace EmployeeEF.DAL
{
    public class AcmeInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<AcmeContext>
    {
        protected override void Seed(AcmeContext context)
        {
            // create an employees variable that will hold a list of all the employees
            var employees = new List<Employee>
            {
                new Employee {FirstMidName="Meryl", LastName="Streep", ActiveEmp=true, Email="MerylStreep@acme.com", IsManager=true, Title="Cat whisperer", Username="MerylStreep", Password="password",ManagerEmplID = 0 },
                new Employee {FirstMidName="John", LastName="Doe", ActiveEmp=true, Email="JohnDoe@acme.com", IsManager=false, Title="Cat herder", Username="JohnDoe", Password="password", ManagerEmplID = 1 },
                new Employee {FirstMidName="Jane", LastName="Doe", ActiveEmp=true, Email="JaneDoe@acme.com", IsManager=false, Title="Cat herder", Username="JaneDoe", Password="password",ManagerEmplID = 1 },
                new Employee {FirstMidName="Mary", LastName="Smith", ActiveEmp=true, Email="MarySmith@acme.com", IsManager=false, Title="Cat herder", Username="MarySmith", Password="password", ManagerEmplID = 1 },
                new Employee {FirstMidName="Lucas", LastName="Jones", ActiveEmp=true, Email="LucasJones@acme.com", IsManager=false, Title="Cat herder",Username="LucasJones", Password="password",ManagerEmplID = 1 },
                new Employee {FirstMidName="George", LastName="Lucas", ActiveEmp=true, Email="GeorgeLucas@acme.com", IsManager=false, Title="Cat herder",Username="GeorgeLucas", Password="password",ManagerEmplID = 1 }

            };

            // walk through each entry in the employees variable and add it as a row in the database Employee table
            employees.ForEach(s => context.Employee.Add(s));
            context.SaveChanges();


        }
    }
}