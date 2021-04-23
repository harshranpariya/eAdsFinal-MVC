using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace eAdsFInalMVC.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<customer1> customers { get; set; }
        public DbSet<product1> product { get; set; }
    }
}