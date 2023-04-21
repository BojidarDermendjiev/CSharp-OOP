namespace _04._Pizza_Calories.Models.Modifiers.Dough
{
    public class Homemade : Dough
    {
        private const double GRAMS = 1.0;
        public Homemade(string flourType, string brakingTechnique) : base(flourType, brakingTechnique, GRAMS) { }
    }
}
