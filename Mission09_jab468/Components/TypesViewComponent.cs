using Microsoft.AspNetCore.Mvc;
using Mission09_jab468.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_jab468.Components
{
    public class TypesViewComponent : ViewComponent
    {
        private IBookListRepository bookListRepository { get; set; }
        public TypesViewComponent (IBookListRepository temp)
        {
            bookListRepository = temp;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedType = RouteData?.Values["categoryType"];

            var types = bookListRepository.books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);
            return View(types);
        }
    }
}
