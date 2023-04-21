namespace _04._Pizza_Calories.Core
{
    using IO;
    using Contracts;
    using IO.Contracts;
    using _04._Pizza_Calories.Models.Modifiers.Dough;
    using _04._Pizza_Calories.Models.Modifiers.Pizza;
    using _04._Pizza_Calories.Models.Modifiers.Topping;
    using System;

    public class Engine : IEngine
    {
        private IReader<string> reader;
        private IWriter<string> writer;
        private IController controller;
        public Engine()
        {
            reader = new Reader();
            writer = new Writer();
        }
        public void Run()
        {
            try
            {
                string pizzaName = reader.ReadLine().Split()[1];

                string[] doughInput = reader.ReadLine().Split();
                string flour = doughInput[1];
                string baking = doughInput[2];
                double grams = double.Parse(doughInput[3]);
                Dough dough = new Dough(flour, baking, grams);
                Pizza pizza = new Pizza(pizzaName, dough);

                string input;
                while ((input = reader.ReadLine()) != "END")
                {
                    string topType = input.Split()[1];
                    double topGrams = double.Parse(input.Split()[2]);
                    Topping topping = new Topping(topType, topGrams);
                    pizza.AddTopping(topping);
                }
                writer.WriteLine(pizza.ToString());
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }
        }
    }
}
