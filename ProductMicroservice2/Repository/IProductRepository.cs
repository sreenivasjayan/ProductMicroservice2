using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductMicroservice2.Models;

namespace ProductMicroservice2
{
    interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProduct(int ProductId);
    }
}
