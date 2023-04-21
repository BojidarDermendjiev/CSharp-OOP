namespace _04._Pizza_Calories.Models.Modifiers.Topping
{
    public class Sauce : Topping
    {
        private const double GRAMS = 0.9;
        public Sauce(string typeOfProduct) : base(typeOfProduct, GRAMS) { }
    }
}
