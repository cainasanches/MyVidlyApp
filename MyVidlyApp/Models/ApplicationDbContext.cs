using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace MyVidlyApp.Models
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Customer> Customers { get; set; }

        public ApplicationDbContext()
        {

        }
    }
}