namespace Animals
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            var cat = new Cat("Peter", "Whiskas");
            var dog = new Dog("George", "Meat");
            Console.WriteLine(cat.ExceptionplainSelf());
            Console.WriteLine(dog.ExceptionplainSelf());
        }
    }
}
