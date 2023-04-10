﻿using Microsoft.AspNetCore.Mvc;
using Intex3_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intex3_4.Controllers
{
    public class CheckoutController : Controller
    {
        private ICheckoutRepository repo { get; set; }
        private Basket basket { get; set; }
        public CheckoutController(ICheckoutRepository temp, Basket b)
        {
            repo = temp;
            basket = b;
        }
        [HttpGet]
        public IActionResult Checkout()
        {
            return View(new Checkout());
        }
        [HttpPost]
        public IActionResult Checkout(Checkout checkout)
        {
            if (basket.Items.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry your basket is empty!");
            }
            if (ModelState.IsValid)
            {
                checkout.Lines = basket.Items.ToArray();
                repo.SaveCheckout(checkout);
                basket.ClearBasket();
                return RedirectToPage("/Completed");
            }
            else
            {
                return View();
            }
        }
    }
}
