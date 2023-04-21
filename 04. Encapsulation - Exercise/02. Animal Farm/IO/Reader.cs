namespace _02._Animal_Farm.IO
{
    using System;
    using Contracts;

    public class Reader : IReader
    {
        public string ReadLine() => Console.ReadLine();
    }
}
