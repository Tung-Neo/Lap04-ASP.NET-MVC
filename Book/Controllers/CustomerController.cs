using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Book.Models;

namespace Book.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(
            [Bind("Name, Emailid")] CustomerModel customerModel)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(customerModel);
        }
    }
}
