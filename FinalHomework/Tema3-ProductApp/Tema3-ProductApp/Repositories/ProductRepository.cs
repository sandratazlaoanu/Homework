using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tema3_ProductApp.Repositories;

namespace Tema3_ProductApp.Models
{
    public class ProductRepository : IProductRepository
    {
        readonly IEnumerable<Product> _products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Cheese",
                Description = "is so good"

            },
            new Product

            {
                Id = 2,
                Name = "Chec",
                Description = " is the best"

            },
            new Product
            {
                Id = 3,
                Name = "Water",
                Description = " is healthy"

            }

        };

        public IEnumerable<Product> Products => _products;


        public Product GetById(int id)
        {
            return _products.SingleOrDefault(x => x.Id == id);
        }
    }
}

