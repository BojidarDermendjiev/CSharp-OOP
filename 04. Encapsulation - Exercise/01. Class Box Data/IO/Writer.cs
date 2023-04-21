namespace _01._Class_Box_Data.IO
{
    using System;
    using Contracts;
    public class Writer : IWriter<string>
    {
        public void Write(string message) => Console.Write(message);

        public void WriteLine(string message) => Console.WriteLine(message);
    }
}
