using HunterShop.Models;

namespace HunterShop.Data
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        Product GetById(int id);
    }
}
