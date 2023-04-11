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
        private IBookListRepository repo;
        public IActionResult Privacy()
        {
            return View();
        }
        public HomeController(IBookListRepository temp)
        {
            repo = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index1()
        {
            return View();
        }
        //public IActionResult Index(string categoryType, int pageNum=1)
        //{
        //    int pageSize = 5;

        //    var x = new BooksViewModel
        //    {
        //        Books = repo.books
        //        .Where(b=> b.Category == categoryType || categoryType==null)
        //        .OrderBy(b => b.Title)
        //        .Skip((pageNum - 1) * pageSize)
        //        .Take(pageSize),

        //        PageInfo = new PageInfo
        //        {
        //            TotalNumBooks = (categoryType == null
        //                ? repo.books.Count()
        //                :repo.books.Where(x=>x.Category == categoryType).Count()),


        //            BooksPerPage = pageSize,
        //            CurrentPage = pageNum
        //        }
        //    };

        //    return View(x);
        //}
}}