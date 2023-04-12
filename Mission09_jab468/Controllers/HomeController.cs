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
using Microsoft.AspNetCore.Authorization;

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

        public IActionResult Create()
        {
            Burialmain burial = new Burialmain();
            return PartialView("_AddBurialPartialView", burial);
        }

        [HttpPost]
        public IActionResult Create(Burialmain bm)
        {
            context.Burialmain.Add(bm);
            context.SaveChanges();
            return RedirectToAction("Index2");
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

        public IActionResult Index2(int recordCount=10,int page=1, long? id=null)


        {
            using (var context = new MummiesContext()) 
            {

                IQueryable<Textile> textilesQuery = context.Textile;
                IQueryable<Burialmain> burialsQuery = context.Burialmain;
                IQueryable<Structure> structureQuery = context.Structure;
                IQueryable<Color> colorQuery = context.Color;
                IQueryable<Textilefunction> functionQuery = context.Textilefunction;

                // Filter by ID if provided
                if (id.HasValue)
                {
                    textilesQuery = textilesQuery.Where(t => t.Id == id.Value);
                    burialsQuery = burialsQuery.Where(b => b.Id == id.Value);
                    structureQuery = structureQuery.Where(s => s.Id == id.Value);
                    colorQuery = colorQuery.Where(c => c.Id == id.Value);
                    functionQuery = functionQuery.Where(f => f.Id == id.Value);
                }


                int skipCount = (page - 1) * recordCount;
                var textiles = textilesQuery.OrderBy(t => t.Id).Skip(skipCount).Take(recordCount).ToList();
                var burials = burialsQuery.OrderBy(b => b.Id).Skip(skipCount).Take(recordCount).ToList();
                var structure = structureQuery.OrderBy(s => s.Id).Skip(skipCount).Take(recordCount).ToList();
                var color = colorQuery.OrderBy(c => c.Id).Skip(skipCount).Take(recordCount).ToList();
                var function = functionQuery.OrderBy(f => f.Id).Skip(skipCount).Take(recordCount).ToList();


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
       [Authorize]
        [HttpPost] 
        public IActionResult Edit(Burialmain burialmain)
        {
            context.Burialmain.Update(burialmain);
            context.SaveChanges();
            return RedirectToAction("Index2");
        }


        [HttpGet]
        [Authorize]
             public IActionResult Delete(int id)
        {
            Burialmain burialmain = context.Burialmain.Where(p => p.Id == id).FirstOrDefault();
            return PartialView("_DeleteBurialPartialView", burialmain);
        }
        [HttpPost]
        [Authorize]
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