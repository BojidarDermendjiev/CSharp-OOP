namespace _05._Restaurant
{
    public class Cake : Dessert
    {
        public decimal CakePrice { get => 5; }
        public override double Grams { get => 250; }
        public override double Calories { get => 1000; }
        public  override decimal Price { get => CakePrice; }
        public Cake(string name) : base(name, 0, 0, 0) { }
    }
}
