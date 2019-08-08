using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tema3_ProductApp.Models
{
    public class ProductRepository
    {
        readonly List<Product> _products = new List<Product>
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

        public List<Product> Products => _products;

        public Product GetById(int id)
        {
            return _products.SingleOrDefault(x => x.Id == id);
        }
    }
}

