namespace _05._Restaurant
{
    public class Food : Product
    {
        private double grams;
        public Food(string name, decimal price, double grams) : base(name, price)
        {
            Grams = grams;
        }
        public virtual double Grams { get => grams; set => grams = value; }
    }
}
