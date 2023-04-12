using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Intex3_4.Models
{
    public class Response
    {
        [Key]
        [Required]
        public int BurialId { get; set; }
        public string Color { get; set; }
        public string Structure { get; set; }  
        public string Sex { get; set; }     
        public string Depth { get; set; }
        public string Stature { get; set; }
        public string Age { get; set; } 
        public string Head { get; set; }
        public string Function { get; set; }
        public string Hair { get; set; }

    }
}
