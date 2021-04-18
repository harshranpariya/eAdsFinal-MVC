using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace eAdsFInalMVC.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<customer> customers { get; set; }
        public DbSet<product> product { get; set; }
    }
}