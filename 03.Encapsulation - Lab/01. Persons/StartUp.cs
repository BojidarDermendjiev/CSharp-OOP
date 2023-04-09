namespace PersonsInfo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            var persons = new List<Person>();
            var numberOfPeople = int.Parse(Console.ReadLine());
            for (int currentGuy = 0; currentGuy < numberOfPeople; currentGuy++)
            {
                var inputLineFromConsole = Console.ReadLine().Split();
                var firstName = inputLineFromConsole[0];
                var lastName = inputLineFromConsole[1];
                var age = int.Parse(inputLineFromConsole[2]);
                persons.Add(new Person(firstName, lastName, age));
            }
            persons.OrderBy(p => p.FirstName)
                .ThenBy(p => p.Age)
                .ToList()
                .ForEach(p => Console.WriteLine(p));
        }
    }
}
