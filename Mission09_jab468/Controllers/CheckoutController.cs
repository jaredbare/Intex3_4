using Microsoft.AspNetCore.Mvc;
using Mission09_jab468.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_jab468.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Checkout()
        {
            return View(new Checkout());
        }
    }
}
