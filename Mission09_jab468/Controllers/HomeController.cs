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


        public IActionResult Supervised()
        {
            return View();
        }
        public IActionResult Unsupervised()
        {
            return View();
        }

        public ActionResult Index2()
        {
            using (var context = new MummiesContext()) // Replace YourDbContext with the actual name of your DbContext class
            {
                // Get data from Textile table
                var textiles = context.Textile.Take(10).ToList(); // Retrieve Textile data from the database and convert to a List

                // Get data from Burialmain table
                var burials = context.Burialmain.Take(10).ToList(); // Call your existing method to retrieve Burialmain data
                var structure = context.Structure.Take(10).ToList();
                var color = context.Color.Take(10).ToList();
                var function = context.Textilefunction.Take(10).ToList();

                // Create and populate view model
                var viewModel = new BodyViewModel()
                {
                    Textiles = textiles,
                    Burials = burials,
                    Structure=structure,
                    Color=color,
                    Function=function
                };

                return View(viewModel);
            }
        }
        public IActionResult Edit (int id)
        {
            Burialmain burialmain = context.Burialmain.Where(p => p.Id == id).FirstOrDefault();
            return PartialView("_EditBurialPartialView", burialmain);
        }
        [HttpPost]
        public IActionResult Edit(Burialmain burialmain)
        {
            context.Burialmain.Update(burialmain);
            context.SaveChanges();
            return RedirectToAction("Index2");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Burialmain burialmain = context.Burialmain.Where(p => p.Id == id).FirstOrDefault();
            return PartialView("_DeleteBurialPartialView", burialmain);
        }
        [HttpPost]
        public IActionResult Delete(Burialmain burialmain)
        {
            context.Burialmain.Remove(burialmain);
            context.SaveChanges();
            return RedirectToAction("Index2");
        }
        public IActionResult Detail(int id)
        {
            Burialmain burialmain = context.Burialmain.Where(p => p.Id == id).FirstOrDefault();
            return PartialView("_BurialDetailsPArtialView", burialmain);
        }

    }
}