namespace _04._Pizza_Calories.Models.Modifiers.Dough
{
    public class Chewy : Dough
    {
        private const double GRAMS = 1.1;
        public Chewy(string flourType, string brakingTechnique) : base(flourType, brakingTechnique, GRAMS) { }
    }
}
