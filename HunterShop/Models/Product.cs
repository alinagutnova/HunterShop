namespace HunterShop.Models
{
    public class Product
    {
        static int count = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }

        public Product(string name, string description, decimal cost)
        { 
            Id = ++count;
            Name = name;
            Description = description;
            Cost = cost;
        }
    }
}
