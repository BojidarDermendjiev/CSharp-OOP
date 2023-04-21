namespace _02._Animal_Farm.Models.Contracts
{
    public interface IChicken
    {
        public string Name { get; }
        public int Age { get; }
        public double ProductPerDay { get; }
        public double CalculateProductPerDay();
    }
}
