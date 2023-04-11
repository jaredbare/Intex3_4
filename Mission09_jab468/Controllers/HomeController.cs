using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Intex3_4.Models;
using Intex3_4.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Intex3_4.Controllers
{
    public class HomeController : Controller
    {

        private MummiesContext context { get; set; }
        public HomeController(MummiesContext temp) => context = temp;

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
            var info = context.Burialmain.ToList();
            return View(info);
        }
        //public IActionResult Index1()
        //{
        //    List<Burialmain> burialmains = new List<Burialmain>();
        //    burialmains = _context.Burialmain.ToList();
        //    return View(burialmains);
        //}
        //public IActionResult Index1()
        //{
        //    using (var context = new MyDbContext())
        //    {
        //        var burialmains = context.Burialmains.ToList();
        //        return View(burialmains);
        //    }
        //}



        public IActionResult Supervised()
        {
            return View();
        }
        public IActionResult Unsupervised()
        {
            return View();
        }

}}