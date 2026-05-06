using HunterShop.Models;

namespace HunterShop.Data
{
    public interface IProductsRepository
    {
        List<Product> GetAll();
        Product TryGetById(int id);
    }
}
