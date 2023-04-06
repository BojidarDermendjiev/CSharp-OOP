namespace _05._Restaurant
{
    public class Product
    {
        private string name;
        private decimal price;
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public virtual string Name { get => name; set => name = value; }
        public virtual decimal Price { get => price; set => price = value; }
    }
}
