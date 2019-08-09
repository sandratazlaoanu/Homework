using Microsoft.AspNetCore.Mvc;
using Tema3_ProductApp.Repositories;

namespace Tema3_ProductApp.Controllers
{
    [Route("/[controller]")]
    public class ProductDbController : Controller
    {
        private readonly IProductRepository _repo;

        public ProductDbController(IProductRepository repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            var products = _repo.Products;

            return View(products);
        }
    }
}