namespace PersonsInfo
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main()
        {
            var persons = new List<Person>();
            var numberOfPeople = int.Parse(Console.ReadLine());
            for (int currentGuy = 0; currentGuy < numberOfPeople; currentGuy++)
            {
                try
                {
                    var inputLineFromConsole = Console.ReadLine().Split();
                    var firstName = inputLineFromConsole[0];
                    var lastName = inputLineFromConsole[1];
                    var age = int.Parse(inputLineFromConsole[2]);
                    var salary = decimal.Parse(inputLineFromConsole[3]);
                    persons.Add(new Person(firstName, lastName, age, salary));
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
            var parcentage = decimal.Parse(Console.ReadLine());
            persons.ForEach(p => p.IncreaseSalary(parcentage));
            persons.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
