namespace _04._Pizza_Calories.Models.Modifiers.Topping
{
    public class Veggies : Topping
    {
        private const double GRAMS = 0.8;
        public Veggies(string typeOfProduct) : base(typeOfProduct, GRAMS) { }
    }
}
