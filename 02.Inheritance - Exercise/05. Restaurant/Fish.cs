namespace _05._Restaurant
{
    public class Fish : MiniDish
    {
        public override double Grams { get => 22; }
        public Fish(string name, decimal price) : base(name, price, 0) { }
    }
}
