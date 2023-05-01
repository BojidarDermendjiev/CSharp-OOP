namespace _04._Wild_Farm.IO
{
    using System;
    using Contracts;

    public class Reader : IReader
    {
        public string ReadLine()
            => Console.ReadLine();
    }
}
