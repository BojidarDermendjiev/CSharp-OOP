namespace _04._Wild_Farm.Core
{
    using Models;
    using Contracts;
    using _04._Wild_Farm.IO.Contracts;
    using _04._Wild_Farm.IO;
    using _04._Wild_Farm.Models.Foods;
    using _04._Wild_Farm.Models.Animals.Bird;
    using _04._Wild_Farm.Models.Animals.Mammal.Tiger;
    using _04._Wild_Farm.Models.Animals.Mammal;

    public class Controller : IController
    {
        private IReader reader;
        private IWriter writer;
        public Controller()
        {
            this.reader = new Reader();
            this.writer = new Writer();
        }
        public Animal GetAnimal(string userInput)
        {
            string[] info = userInput.Split();
            string type = info[0];
            string name = info[1];
            double weight = double.Parse(info[2]);
            switch (type)
            {
                case "Hen":
                    return new Hen(name, weight, double.Parse(info[3]));
                case "Owl":
                    return new Owl(name, weight, double.Parse(info[3]));
                case "Cat":
                    return new Cat(name, weight, info[3], info[4]);
                case "Tiger":
                    return new Tiger(name, weight, info[3], info[4]);
                case "Dog":
                    return new Dog(name, weight, info[3]);
                case "Mouse":
                    return new Mouse(name, weight, info[3]);
                default:
                    return null;
            }
           
        }
        public Food GetFood(string userInput)
        {
            string[] info = userInput.Split();
            string type = info[0];
            int quantity = int.Parse(info[1]);
            switch (type)
            {
                case "Fruit":
                    return new Fruit(quantity);
                case "Meat":
                    return new Meat(quantity);
                case "Seeds":
                    return new Seeds(quantity);
                case "Vegetable":
                    return new Vegetable(quantity);
                default:
                    return null;
            }
        }
    }
}
