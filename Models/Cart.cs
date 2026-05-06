namespace HunterShop.Models
{
    public class Cart
    {
        public Guid Id { get; set; }
        public int UserId { get; set; }
        public List<CartItem> Items { get; set; }
        public decimal Cost
        {
            get { return Items.Sum(x => x.Cost); }
        }
    }

}
