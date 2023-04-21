namespace _04._Pizza_Calories.IO
{
    using System;
    using Contracts;

    public class Reader : IReader<string>
    {
        public string ReadLine()
            => Console.ReadLine();  
    }
}
