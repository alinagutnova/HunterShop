using HunterShop.Models;

namespace HunterShop.Data
{
    public interface ICartsRepository
    {
        Cart TryGetByUserId(int id);
        void Add(Product product, int UserId);
    }

}
