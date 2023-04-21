namespace _04._Pizza_Calories.Models.Modifiers.Dough
{
    public class White : Dough
    {
        private const double GRAMS = 1.5;
        public White(string flourType, string brakingTechnique) : base(flourType, brakingTechnique, GRAMS) { }
    }
}
