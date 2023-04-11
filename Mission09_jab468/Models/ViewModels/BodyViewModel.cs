using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intex3_4.Models.ViewModels
{
    public class BodyViewModel
    {
        public IQueryable<Burialmain> Id { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}
