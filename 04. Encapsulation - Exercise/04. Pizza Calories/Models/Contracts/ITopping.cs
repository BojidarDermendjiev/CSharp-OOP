namespace _04._Pizza_Calories.Models.Contracts
{
    public interface ITopping
    {
        public string TypeOfProduct { get; }
        public double Grams { get; }
    }
}
