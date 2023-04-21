namespace _03._Shopping_Spree.Core
{
    using _03._Shopping_Spree.Core.Contracts;
    using _03._Shopping_Spree.IO;
    using _03._Shopping_Spree.IO.Contracts;
    using System;
    using System.Linq;

    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;
        private IController controller;
        public Engine()
        {
            reader = new Reader();
            writer = new Writer();
            controller = new Controller();
        }
        public void Run()
        {

            try
            {
                var inputLineFromConsole = reader.ReadLine();
                var output = string.Empty;
                var info = inputLineFromConsole.Split(";");
                for (int currentIndex = 0; currentIndex < info.Length; currentIndex++)
                {
                    var name = info[currentIndex].Split("=", System.StringSplitOptions.RemoveEmptyEntries).First();
                    var money = decimal.Parse(info[currentIndex].Split("=", System.StringSplitOptions.RemoveEmptyEntries).Last());
                    output = controller.RegisterPerson(name, money);
                    writer.WriteLine(output);
                }
                inputLineFromConsole = reader.ReadLine();
                info = inputLineFromConsole.Split(";", System.StringSplitOptions.RemoveEmptyEntries);
                for (int currentIndex = 0; currentIndex < info.Length; currentIndex++)
                {
                    var name = info[currentIndex].Split("=", System.StringSplitOptions.RemoveEmptyEntries).First();
                    var cost = decimal.Parse(info[currentIndex].Split("=", System.StringSplitOptions.RemoveEmptyEntries).Last());
                    output = controller.RegisterProduct(name, cost);
                    writer.WriteLine(output);
                }
                while (true)
                {
                    inputLineFromConsole = reader.ReadLine();
                    if (inputLineFromConsole == "END")
                        Environment.Exit(0);
                    if (inputLineFromConsole == "Report")
                    { 
                        writer.WriteLine(controller.UsersReport());
                        continue;
                    }
                    var nameOfPerson = inputLineFromConsole.Split(" ", System.StringSplitOptions.RemoveEmptyEntries)[0];
                    var nameOfProduct = inputLineFromConsole.Split(" ", System.StringSplitOptions.RemoveEmptyEntries)[1];
                    output = controller.Orders(nameOfPerson, nameOfProduct);
                    writer.WriteLine(output);
                }
            }
            catch (ArgumentException ae)
            {
                writer.WriteLine(ae.Message);
            }
        }
    }
}
