using HunterShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace HunterShop.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult AllProducts()
        {
            List<Product> products = new List<Product>()
            {
                new Product("лук тисовый","лук выполнен из ценной породы дерева",5000),
                new Product("ружье дальнобойное","дистанция 500 м",12000)
            };
            return View(products);
        }
    }
}
