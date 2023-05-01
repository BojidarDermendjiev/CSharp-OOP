namespace _04._Wild_Farm.Core
{
    using Contracts;
    using _04._Wild_Farm.Models;
    using System.Collections.Generic;
    using System;

    public class Engine : IEngine
    {
        private IController controller;
        public Engine()
        {
            this.controller = new Controller();
        }
        public void Run()
        {
            List<Animal> animals = new List<Animal>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                Animal animal = controller.GetAnimal(input);
                Console.WriteLine(animal.Sound());
                Food food = controller.GetFood(Console.ReadLine());
                animal.Eat(food);
                animals.Add(animal);
            }
            animals.ForEach(animal => Console.WriteLine(animal));
        }
    }
}
