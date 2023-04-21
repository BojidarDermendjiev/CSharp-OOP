namespace _01._Class_Box_Data.IO
{
    using System;
    using Contracts;
    public class Reader : IReader<string>
    {
        public string ReadLine() => Console.ReadLine();
    }
}
