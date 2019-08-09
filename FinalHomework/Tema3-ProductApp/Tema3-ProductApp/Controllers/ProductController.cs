using Microsoft.AspNetCore.Mvc;
using Tema3_ProductApp.Models;

namespace Tema3_ProductApp.Controllers
{
    [Route("/[controller]")]
    public class ProductController : Controller
    {
        private readonly ProductRepository _repo;

        public ProductController(ProductRepository repo)
        {
            _repo = repo;
        }
        /*public IActionResult Index()
        {
            var products = _repo.Products;

            return View(products);
        }*/
        public IActionResult ReturnProduct(int id)
        {
            var product = _repo.GetById(id);

            return View(product);
        }
    }
}
