using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mission09_jab468.Infrastructure;
using Mission09_jab468.Models;

namespace Mission09_jab468.Pages
{
    public class PurchaseModel : PageModel
    {
        private IBookListRepository repo { get; set; }

        public PurchaseModel (IBookListRepository temp)
        {
            repo = temp;
        }

        public Basket basket { get; set; }
        public string ReturnUrl { get; set; }
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
           
        }
        public IActionResult OnPost(int bookId, string returnUrl)
        {
            Book b = repo.books.FirstOrDefault(x => x.BookId == bookId);
            basket.AddItem(b, 1);

         

            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
