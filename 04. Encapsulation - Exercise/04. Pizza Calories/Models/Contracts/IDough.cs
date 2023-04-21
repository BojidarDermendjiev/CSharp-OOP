namespace _04._Pizza_Calories.Models.Contracts
{
    public interface IDough
    {
        public string FlourType { get; }
        public string BakingTechnique { get; }
        public double Grams { get; }
    }
}
