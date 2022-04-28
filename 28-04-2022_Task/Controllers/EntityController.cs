using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductEntity.Models;
namespace ProductEntity.Controllers
{
    public class EntityController : Controller
    {
        public IActionResult Customer()
        {
            return View();
        }
        public IActionResult Create(Customer c)
        {
            if (ModelState.IsValid)
            {
                CustomerDbcontext dbcontext = new CustomerDbcontext();
                dbcontext.Add(c);
                dbcontext.SaveChanges();
                return View("Product");
            }
            return View("Customer");
        }
        public IActionResult Product()
        {
            return View();
        }
        //public IActionResult Show(Product p)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        ProductDbcontext dbcontext = new ProductDbcontext();
        //        dbcontext.Add(p);
        //        dbcontext.SaveChanges();
        //        return View("");
        //    }
        //    return View("View");
        //}
    }
}
