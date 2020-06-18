using examapi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace examapi.Data
{
    public class MockProductRepo : IProductRepo
    {
        public IEnumerable<Product> GetAppProduct()
        {
            var products = new List<Product>
            {
                //Creating test data
                new Product { ID = 1, Name = "Æg", Description = "Friske æg der kommer fra en høne", Unit = "2", Amount = "10", Price = 20}
            };

            return products;
        }

        public Product GetProductById(int id)
        {
            return new Product { ID = 1, Name = "Æg", Description = "Friske æg der kommer fra en høne", Unit = "2", Amount = "10", Price = 20 };
        }
    }
}
