using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Storage.Models
{
    public class Product
    {
        public int Id { get; set; }

        [StringLength(30, ErrorMessage = "Max 30 tecken")]
        [Display(Name = "Namn")]
        [Required]
        public string Name { get; set; }
        public int Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime Orderdate { get; set; }

        [Required]
        public string Category { get; set; }
        public string Shelf { get; set; }
        [Range(0, 10000)]
        public int Count { get; set; }
        public string Description { get; set; }

    }

}
