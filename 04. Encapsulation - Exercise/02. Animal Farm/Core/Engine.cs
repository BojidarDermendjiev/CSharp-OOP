namespace _02._Animal_Farm.Core
{
    using _02._Animal_Farm.Models;
    using _02._Animal_Farm.Models.Contracts;
    using _02._Animal_Farm.Utilities.Messages;
    using Core.Contracts;
    using IO;
    using IO.Contracts;
    using System;

    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;
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
                var nameOfTheChicken = reader.ReadLine();
                var ageOfTheChicken = int.Parse(reader.ReadLine());
                IChicken chicken = new Chicken(nameOfTheChicken, ageOfTheChicken);
                chicken.CalculateProductPerDay();
                outputMessage = chicken.ToString();
                writer.WriteLine(outputMessage);
            }
            catch (AgeArgumentValueShouldBeBetween0To15 message)
            {
                writer.WriteLine(message.Message);
            }
            catch (NameArgumentsCannotBeNullOrWhiteSpace message)
            {
                writer.WriteLine(message.Message);
            }
        }
    }
}
