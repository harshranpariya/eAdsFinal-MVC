using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eAdsFInalMVC.Models
{
    public class ProductOwner
    {
        public List<product1> lstProduct { get; set; }
        public List<customer1> lstOwner { get; set; }
    }
}