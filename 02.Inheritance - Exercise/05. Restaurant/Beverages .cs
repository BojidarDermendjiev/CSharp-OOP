namespace _05._Restaurant
{
    public class Beverages : Product
    {
        private double milliliters;
        public Beverages(string name, decimal price, double milliliters) : base(name, price)
        {
            Milliliters = milliliters;
        }
        public double Milliliters { get => milliliters; set => milliliters = value; }
    }
}
