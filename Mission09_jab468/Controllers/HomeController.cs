using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission09_jab468.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_jab468.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        private IBookListRepository repo;

        public HomeController(IBookListRepository temp)
        {
            repo = temp;
        }

        //private BookstoreContext context { get; set; }
        //public HomeController (BookstoreContext bookstoreContext)
        //{
        //    context = bookstoreContext;
        //}

        public IActionResult Index()
        {
            var bookList = repo.books.ToList();
            return View(bookList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
