namespace _04._Wild_Farm.Core.Contracts
{
    using _04._Wild_Farm.Models;
    public interface IController
    {
        public Food GetFood(string userInput);
        public Animal GetAnimal(string userInput);
    }
}
