using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeEF.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EmployeeEF.DAL
{
    public class AcmeContext : DbContext
    {
        // "AcmeContext" is the name of the connection string
        public AcmeContext() : base("AcmeContext")
        {
        }
        public DbSet<Employee> Employee { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
