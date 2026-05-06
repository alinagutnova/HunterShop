using HunterShop.Models;

namespace HunterShop.Data
{
    public class CartsRepositoryInMemory : ICartsRepository
    {
        List<Cart> carts = new List<Cart>();

        public Cart TryGetByUserId(int id)
        {
            foreach(var cart in carts)
                if (cart.UserId == id) return cart;
            return null;
        }

        CartItem AddNewItem(Product product)
        {
            var cartItem = new CartItem();
            cartItem.Id = Guid.NewGuid();
            cartItem.Amount = 1;
            cartItem.Product = product;
            return cartItem;
        }

        CartItem TryGetCartItemByProduct(Cart cart, Product product)
        {
            foreach (var c in cart.Items)
                if (c.Product == product) return c;
            return null;
        }

        public void Add(Product product, int UserId)
        {
            var existingCart = TryGetByUserId(UserId);
            if (existingCart == null)
            {
                var newCart = new Cart();
                newCart.Id = Guid.NewGuid();
                newCart.UserId = UserId;
                newCart.Items = new List<CartItem>();
                newCart.Items.Add(AddNewItem(product));
                carts.Add(newCart);
            }
            else
            {
                var existingCartItem = TryGetCartItemByProduct(existingCart, product);
                if (existingCartItem != null)
                {
                    existingCartItem.Amount++;
                }
                else
                {
                    existingCart.Items.Add(AddNewItem(product));
                }
            }
        }
    }

}
