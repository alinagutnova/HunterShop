using HunterShop.Data;
using HunterShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace HunterShop.Controllers
{
    public class ProductController : Controller
    {
        IProductsRepository productRepository;

        public ProductController(IProductsRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IActionResult AllProducts()
        {
            return View(productRepository.GetAll());
        }

        public IActionResult Details(int id)
        {
            return View(productRepository.TryGetById(id));
        }
    }
}
