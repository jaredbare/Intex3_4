using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Intex3_4.Models;
using Intex3_4.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Intex3_4.Controllers
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

        public IActionResult Index(string categoryType, int pageNum=1)
        {
            int pageSize = 5;

            var x = new BooksViewModel
            {
                Books = repo.books
                .Where(b=> b.Category == categoryType || categoryType==null)
                .OrderBy(b => b.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PageInfo = new PageInfo
                {
                    TotalNumBooks = (categoryType == null
                        ? repo.books.Count()
                        :repo.books.Where(x=>x.Category == categoryType).Count()),


                    BooksPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };


            //var bookList = repo.books
            //    .OrderBy(b => b.Title)
            //    .Skip((pageNum-1)*pageSize)
            //    .Take(pageSize);
            return View(x);
        }
        [Authorize]
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
