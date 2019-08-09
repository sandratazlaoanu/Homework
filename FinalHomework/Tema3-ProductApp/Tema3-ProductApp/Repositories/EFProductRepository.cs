using System.Collections.Generic;
using Tema3_ProductApp.DatabaseContext;
using Tema3_ProductApp.Models;

namespace Tema3_ProductApp.Repositories
{
    public class EFProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;
        public EFProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> Products => _context.Products;
    }
}
