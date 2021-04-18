using eAdsFInalMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eAdsFInalMVC.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            DatabaseContext context = new DatabaseContext();
            var product = context.product.ToList();
            return View(product);
        }
    }
}