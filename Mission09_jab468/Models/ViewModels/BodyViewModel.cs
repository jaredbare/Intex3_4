using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intex3_4.Models.ViewModels
{
    public class BodyViewModel
    {
        public List<Textile> Textiles { get; set; }
        public List<Burialmain> Burials { get; set; }
        public List<Structure> Structure { get; internal set; }
        public List<Color> Color { get; internal set; }
        public List<Textilefunction> Function { get; internal set; }
    }
}
