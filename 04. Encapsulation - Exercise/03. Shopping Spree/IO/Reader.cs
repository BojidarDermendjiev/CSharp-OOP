namespace _03._Shopping_Spree.IO
{
    using System;
    using Contracts;

    public class Reader : IReader
    {
        public string ReadLine() => Console.ReadLine();
    }
}
