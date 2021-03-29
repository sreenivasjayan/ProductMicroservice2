using ProductMicroservice2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductMicroservice2.Repository
{
    public class ProductRepository : IProductRepository
    {
        public Product GetProduct(int ProductId)
        {
            Product prod = new Product();
            prod.Id = 101;
            prod.Name = "Umbella";
            prod.Description = "Big Umbrella";
            prod.Price = 500;
            prod.CategoryId = 1000;
            return prod;
        }

        public IEnumerable<Product> GetProducts()
        {
            List<Product> products = new List<Product>();

            Product prod;
            prod = new Product();
            prod.Id = 101;
            prod.Name = "Umbella";
            prod.Description = "Big Umbrella";
            prod.Price = 500;
            prod.CategoryId = 1000;

            prod = new Product();
            prod.Id = 102;
            prod.Name = "Microwave";
            prod.Description = "Microwave";
            prod.Price = 6000;
            prod.CategoryId = 1001;

            products.Add(prod);

            return products;

        }
    }
}
