using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_jab468.Models
{
    public class EFBookListRepository : IBookListRepository
    {
        private BookstoreContext context { get; set; }
        public EFBookListRepository (BookstoreContext bookstoreContext)
        {
            context = bookstoreContext;
        }
        public IQueryable<Book> books => context.Books;
    }
}
