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

            var lst = new ProductOwner();
            lst.lstOwner = getCustomer();
            lst.lstProduct = getProduct();

            return View(lst);
        }


        [HttpGet]
        public ActionResult SingleProduct(int id)
        {
            DatabaseContext context = new DatabaseContext();
            var sigleProduct = context.product.Single(x => x.pId == id);
            var user = context.customers.Single(x => x.Id == sigleProduct.ownerid);
            ViewBag.username = user.cName;
            return View(sigleProduct);
        }

        public List<product1> getProduct()
        {
            DatabaseContext context = new DatabaseContext();
            return context.product.ToList();
        }

        public List<customer1> getCustomer()
        {
            DatabaseContext context = new DatabaseContext();
            return context.customers.ToList();
        }
    }
}