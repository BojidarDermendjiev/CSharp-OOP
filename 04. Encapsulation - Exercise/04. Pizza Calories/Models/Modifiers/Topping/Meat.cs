namespace _04._Pizza_Calories.Models.Modifiers.Topping
{
    public class Meat : Topping
    {
        private const double GRAMS = 1.2;
        public Meat(string typeOfProduct) : base(typeOfProduct, GRAMS) { }
    }
}
