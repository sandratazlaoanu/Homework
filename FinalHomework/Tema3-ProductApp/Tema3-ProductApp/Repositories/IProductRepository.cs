using System.Collections.Generic;
using Tema3_ProductApp.Models;

namespace Tema3_ProductApp.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }

    }
}
