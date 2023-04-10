using Microsoft.AspNetCore.Mvc;
using Intex3_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intex3_4.Components
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
