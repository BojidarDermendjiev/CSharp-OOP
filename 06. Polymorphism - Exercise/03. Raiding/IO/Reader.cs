namespace _03._Raiding.IO
{
    using System;
    using Contracts;
    public class Reader : IReader<string>
    {
        public string ReadLine() => Console.ReadLine();
    }
}
