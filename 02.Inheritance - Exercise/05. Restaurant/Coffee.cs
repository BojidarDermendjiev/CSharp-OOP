namespace _05._Restaurant
{
    public class Coffee : HotBeverage
    {
        public double CoffeeMilliliters { get => 50; }
        public decimal CoffeePrice { get => 3.50M; }
        public double Coffeine { get; set; }
        public Coffee(string name, double coffeine) : base(name, 0, 0)
        {
            Coffeine = coffeine;
        }
    }
}
