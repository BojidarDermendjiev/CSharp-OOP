namespace _04._Wild_Farm.Core
{
    using System.Collections.Generic;
    using IO;
    using Models;
    using Contracts;
    using IO.Contracts;

    public class Engine : IEngine
    {
        private IController controller;
        private IReader reader;
        private IWriter writer;
        public Engine()
        {
            this.controller = new Controller();
            this.reader = new Reader();
            this.writer = new Writer();
        }
        public void Run()
        {
            List<Animal> animals = new List<Animal>();
            string input;
            while ((input = reader.ReadLine()) != "End")
            {
                Animal animal = controller.GetAnimal(input);
                writer.WriteLine(animal.Sound());
                Food food = controller.GetFood(reader.ReadLine());
                animal.Eat(food);
                animals.Add(animal);
            }
            animals.ForEach(animal => writer.WriteLine(animal.ToString()));
        }
    }
}
