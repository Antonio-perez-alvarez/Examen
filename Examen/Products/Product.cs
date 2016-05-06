using Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Products
{
    public class Product:EntityBase
    {
        [Required]
        [MaxLength]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}
