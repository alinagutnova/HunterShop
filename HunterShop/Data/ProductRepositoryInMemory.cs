using HunterShop.Models;

namespace HunterShop.Data
{
    public class ProductRepositoryInMemory : IProductRepository
    {
        List<Product> products;

        public ProductRepositoryInMemory()
        {
            products = new List<Product>()
            {
                new Product("лук тисовый","лук выполнен из ценной породы дерева",5000),
                new Product("ружье дальнобойное","дистанция 500 м",12000)
            };
        }

        public List<Product> GetAll()
        {
            return products;
        }

        public Product GetById(int id)
        {
            foreach (Product product in products)
            {
                if (product.Id == id) return product;
            }
            return null;
        }
    }
}
