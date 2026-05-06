using HunterShop.Data;
using HunterShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace HunterShop.Controllers
{
    public class CartController : Controller
    {
        ICartsRepository cartsRepository;
        IProductsRepository productsRepository;
        int userId = 1;

        public CartController(ICartsRepository cartsRepository, IProductsRepository productsRepository)
        {
            this.cartsRepository = cartsRepository;
            this.productsRepository = productsRepository;
        }

        public IActionResult Index()
        {
            Cart cart = cartsRepository.TryGetByUserId(userId);
            return View(cart);
        }

        public IActionResult Add(int id)
        {
            var product = productsRepository.TryGetById(id);
            if (product != null)
            {
                cartsRepository.Add(product, userId);
            }
            return RedirectToAction("Index");
        }

    }
}
