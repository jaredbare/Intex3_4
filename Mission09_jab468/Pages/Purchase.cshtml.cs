using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Intex3_4.Infrastructure;
using Intex3_4.Models;

namespace Intex3_4.Pages
{
    public class PurchaseModel : PageModel
    {
        private IBookListRepository repo { get; set; }

        public PurchaseModel (IBookListRepository temp, Basket b)
        {
            repo = temp;
            basket = b;
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
        public IActionResult OnPostRemove(int bookId, string returnUrl)
        {
            basket.RemoveItem(basket.Items.First(x => x.Book.BookId == bookId).Book);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
