namespace _04._Pizza_Calories.Models.Modifiers.Dough
{
    public class Wholegrain : Dough
    {
        private const double GRAMS = 1.0;
        public Wholegrain(string flourType, string brakingTechnique) : base(flourType, brakingTechnique, GRAMS) { }
    }
}
