using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using examapi.Model;

namespace examapi.Data
{
    public interface IProductRepo
    {
        IEnumerable<Product> GetAppProduct();
        Product GetProductById(int ID);
    }
}
