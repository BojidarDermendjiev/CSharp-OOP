namespace _06._Animals
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main()
        {
            string input;
            List<Animal> animals = new List<Animal>();
            while ((input = Console.ReadLine()) != "Beast!")
            {
                string type = input;
                string[] tokens = Console.ReadLine().Split();
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string gender = tokens[2];
                if (age < 0 || (gender != "Male" && gender != "Female"))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                Animal animal = new Animal();
                switch (type)
                {
                    case "Dog": animal = new Dog(name, age, gender); break;
                    case "Cat": animal = new Cat(name, age, gender); break;
                    case "Frog": animal = new Frog(name, age, gender); break;
                    case "Kitten": animal = new Kitten(name, age); break;
                    case "Tomcat": animal = new Tomcat(name, age); break;
                }
                animals.Add(animal);
            }
            animals.ForEach(x => Console.WriteLine(x));
        }
    }
}
