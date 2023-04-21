namespace _04._Pizza_Calories.Models.Modifiers.Topping
{
    public class Cheese : Topping
    {
        private const double GRAMS = 1.1;
        public Cheese(string typeOfProduct) : base(typeOfProduct, GRAMS) { }
    }
}
