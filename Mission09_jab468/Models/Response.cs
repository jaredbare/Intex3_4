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

        [Required]
        public string Title { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public string Structure { get; set; }
        [Required]
        public string Sex { get; set; }
        [Required]
        public string Depth { get; set; }
        [Required]
        public string Stature { get; set; }
        [Required]
        public string Age { get; set; }
        [Required]
        public string Head { get; set; }
        [Required]
        public string Function { get; set; }
        [Required]
        public string Hair { get; set; }

    }
}
