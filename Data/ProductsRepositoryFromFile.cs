using HunterShop.Models;
using System.Text.Json;

namespace HunterShop.Data
    {
        public class ProductsRepositoryFromFile : IProductsRepository
        {
            List<Product> products;

            public ProductsRepositoryFromFile()
            {
                string jsonString = File.ReadAllText("Data/products.json");
                products = JsonSerializer.Deserialize<List<Product>>(jsonString);
            }

            public List<Product> GetAll()
            {
                return products;
            }

            public Product TryGetById(int id)
            {
                foreach (Product product in products)
                {
                    if (product.Id == id) return product;
                }
                return null;
            }
        }
    }
