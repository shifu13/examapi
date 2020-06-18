using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace examapi.Model
{
    public class Product
    {
        [Required]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public string Amount { get; set; }
        public int Price { get; set; }
        public ICollection<ProductCategory> ProductCategory { get; set; }
    }
}
