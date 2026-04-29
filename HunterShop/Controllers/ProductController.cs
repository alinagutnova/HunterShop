using HunterShop.Data;
using HunterShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace HunterShop.Controllers
{
    public class ProductController : Controller
    {
        IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IActionResult AllProducts()
        {
            return View(productRepository.GetAll());
        }

        public IActionResult Details(int id)
        {
            return View(productRepository.GetById(id));
        }
    }
}
