namespace _01._Person
{
    using _01._Person.Exception;
    using System;
    public class StartUp
    {
        static void Main()
        {
            try
            {
                Person person;
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());

                if (age > 15)
                    person = new Person(name, age);
                else
                    person = new Child(name, age);

                Console.WriteLine(person);

            }
            catch (InvalidAge ia)
            {
                Console.WriteLine(ia.Message);
            }
            catch (InvalidName @in)
            {
                Console.WriteLine(@in.Message);
            }
        }
    }
}
