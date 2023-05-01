namespace _04._Wild_Farm.Models.Contracts
{
    public interface IAnimal
    {
        public string Sound();
        public void Eat(Food food);
    }
}
