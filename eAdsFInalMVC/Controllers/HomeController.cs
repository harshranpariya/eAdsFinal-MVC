using eAdsFInalMVC.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using eAdsFInalMVC.Controllers;
using Microsoft.AspNetCore.Identity;

namespace eAdsFInalMVC.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var uid = User.Identity.GetUserId();
            DatabaseContext context = new DatabaseContext();
            var cus = context.customers.Find(uid);

            if(cus == null)
            {
              var email =  User.Identity.GetUserName();

                customer1 c = new customer1(uid, email);
                context.customers.Add(c);
                context.SaveChanges();

            }


            return View();
        }
    }
}
