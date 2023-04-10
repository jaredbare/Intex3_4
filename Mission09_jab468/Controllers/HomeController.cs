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
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        private IBookListRepository repo;

        //private BookstoreContext mummyContext { get; set; }

        //Constructor
        //public HomeController(BookstoreContext artifact)
        //{
        //    mummyContext = artifact;
        //}

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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Background()
        {
            return View();
        }
        //[HttpGet]
        //public IActionResult Edit(int BurialId)
        //{
        // there's no need to create something totally new here
        // so instead we send it back to our 'list of options'
        //COME BACK HERE AND CHANGE THE NAMES
        //ViewBag.Categories = mummyContext.Categories.ToList();
        //var burial = mummyContext.Responses.Single(x => x.BurialId == BurialId);
        // we return to the view (our application) so that we can see and make changes
        // we pass in the var we just created
        //return View("MovieForm", burial);
        //}

        //[HttpPost]
        // receives an instance of an application response that we can refer to
        //        public IActionResult Edit(Response egypt)
        //        {
        //            here we update and save changes based on the info passed above
        //            mummyContext.Update(egypt);
        //            mummyContext.SaveChanges();

        //            we pass it all into the waitlist cshtml
        //             remember that you must also specify an action that will
        //             actually go back to the previous waitlist action we made so it
        //             not only shows the view but also pulls in the actions
        //            return RedirectToAction("Waitlist");

        //        }

        //        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //        public IActionResult Error()
        //        {
        //            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //        }
    }
}
