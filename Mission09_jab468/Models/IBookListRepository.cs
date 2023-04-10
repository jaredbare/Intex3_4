using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intex3_4.Models
{
    public interface IBookListRepository
    {
        IQueryable<Book> books { get; }

    }
}
