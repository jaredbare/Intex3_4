using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Intex3_4.Models
{
    public class Checkout
    {
        [Key]
        [BindNever]
        public int CheckoutId { get; set; }

        [BindNever]
        public ICollection<BasketLineItem> Lines { get; set; }
        [Required(ErrorMessage ="Enter Name:")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter Address:")]
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }
        [Required(ErrorMessage = "Enter City:")]
        public string City { get; set; }

        [Required(ErrorMessage = "Enter State:")]
        public string State { get; set; }

        [Required(ErrorMessage = "Enter Zip:")]
        public string Zip { get; set; }
        [Required(ErrorMessage = "Enter Country:")]
        public string Country { get; set; }
        public bool Gift { get; set; }
    }
}
