using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Supervised()
        {
            return View();
        }
        public IActionResult Unsupervised()
        {
            return View();
        }

}}