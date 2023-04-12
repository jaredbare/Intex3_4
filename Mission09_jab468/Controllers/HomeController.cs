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

        public IActionResult Index2(int recordCount=10,int page=1)

        {
            //int defaultRecordCount = 10;
            //int recordCount = defaultRecordCount;
            //if (Request.Form["recordCount"] != null)
            //{
            //    int.TryParse(Request.Form["recordCount"], out recordCount);
            //}
            //else if (Session["recordCount"]) != null){
            //    recordCount = (int)Session["recordCount"];
            //}
            //Session["recordCount"] = recordCount;

            using (var context = new MummiesContext()) 
            {
                int skipCount = (page - 1) * recordCount;
                var textiles = context.Textile.Skip(skipCount).Take(recordCount).ToList(); 
                var burials = context.Burialmain.Skip(skipCount).Take(recordCount).ToList(); 
                var structure = context.Structure.Skip(skipCount).Take(recordCount).ToList();
                var color = context.Color.Skip(skipCount).Take(recordCount).ToList();
                var function = context.Textilefunction.Skip(skipCount).Take(recordCount).ToList();

                // Create and populate view model
                var viewModel = new BodyViewModel()
                {
                    Textiles = textiles,
                    Burials = burials,
                    Structure = structure,
                    Color = color,
                    Function = function
                };
                // Calculate total number of records
                int totalRecords = context.Burialmain.Count(); // assuming Textile table is used as the base for pagination

                // Calculate total number of pages
                int totalPages = (int)Math.Ceiling((double)totalRecords / recordCount);

                // Pass pagination information to view
                ViewBag.TotalPages = totalPages;
                ViewBag.CurrentPage = page;
                return View(viewModel);
            }
        }
        public IActionResult Edit(int id)
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