using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sampleWebapi.Models
{
    public class Product
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public Product(string productName, decimal price, string description)
        {
            ProductName = productName;
            Description = description;
            Price = price;
        }
    }
}
