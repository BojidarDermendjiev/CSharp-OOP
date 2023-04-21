namespace _01._Class_Box_Data.Core
{
    using System;
    using Contracts;
    using IO;
    using IO.Contracts;
    using Models;
    using Models.Contracts;

    public class Engine : IEngine
    {
        private IReader<string> reader;
        private IWriter<string> writer;
        public Engine()
        {
            this.reader = new Reader();
            this.writer = new Writer();
        }
        public void Run()
        {
            try
            {
                string outputMessage = string.Empty;
                var length = Double.Parse(reader.ReadLine());
                var width = Double.Parse(reader.ReadLine());
                var height = Double.Parse(reader.ReadLine());
                IBox box = new Box(length, width, height);
                outputMessage = box.ToString();
                writer.WriteLine(outputMessage);
            }
            catch (ArgumentException ae)
            {
                writer.WriteLine(ae.Message);
            }
        }
    }
}
