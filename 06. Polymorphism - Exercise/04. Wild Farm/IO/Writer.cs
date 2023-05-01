namespace _04._Wild_Farm.IO
{
    using System;
    using Contracts;
    public class Writer : IWriter
    {
        void IWriter.Write(string message)
            => Console.Write(message);
        public void WriterLine(string message)
            => Console.WriteLine(message);

    }
}
