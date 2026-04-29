using HunterShop.Models;
using System.Text.Json;

namespace HunterShop.Data
    {
        public class ProductRepositoryFromFile : IProductRepository
        {
            List<Product> products;

            public ProductRepositoryFromFile()
            {
                string jsonString = File.ReadAllText("Data/products.json");
                products = JsonSerializer.Deserialize<List<Product>>(jsonString);
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
