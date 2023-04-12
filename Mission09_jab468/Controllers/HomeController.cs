﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Intex3_4.Models;
using Intex3_4.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Intex3_4.Controllers
{
    public class HomeController : Controller
    {
        private readonly MummiesContext _context;
        public HomeController(MummiesContext temp)
        {
            _context = temp;
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index1()
        {
            var info = _context.Burialmain.OrderBy(x=>x.Id).ToList();
            return View(info);
        }

        [HttpGet]
        public IActionResult Supervised()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Supervised(Burialmain bm)
        {
            if (ModelState.IsValid)
            {
                //talk to emily about importing models into the supervised page
                return View("Confirmation", bm);
            }
            else //If Invalid
            {
                return View();
            }
        }
        public IActionResult Unsupervised()
        {
            //all we need to do is return the view since its all pictures here.
            return View();
        }

    }
}