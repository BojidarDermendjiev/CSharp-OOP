namespace _04._Pizza_Calories.Models.Modifiers.Dough
{
    public class Crispy : Dough
    {
        private const double GRAMS = 0.9;
        public Crispy(string flourType, string brakingTechnique) : base(flourType, brakingTechnique, GRAMS) { }
    }
}
