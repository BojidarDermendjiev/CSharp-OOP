namespace _02._Vehicles_Extension
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            Car car; Truck truck; Bus bus;
            GetInfoFromConsole(out car, out truck, out bus);
            Engine(car, truck, bus);
            IO(car, truck, bus);
        }

        private static void GetInfoFromConsole(out Car car, out Truck truck, out Bus bus)
        {
            string[] carInfo = Console.ReadLine().Split();
            car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));
            string[] truckInfo = Console.ReadLine().Split();
            truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));
            string[] busInfo = Console.ReadLine().Split();
            bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));
        }
        private static void Engine(Car car, Truck truck, Bus bus)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            for (int currenCommand = 0; currenCommand < numberOfCommands; currenCommand++)
            {
                string[] tokens = Console.ReadLine().Split();
                var command = tokens.First();
                var type = tokens.Skip(1).First();
                var value = double.Parse(tokens.Last());

                if (command == "Drive")
                    switch (type)
                    {
                        case "Car":
                            car.Drive(value);
                            break;
                        case "Truck":
                            truck.Drive(value);
                            break;
                        case "Bus":
                            bus.Drive(value);
                            break;
                    }
                else if (command == "Refuel")
                    switch (type)
                    {
                        case "Car":
                            car.Refuel(value);
                            break;
                        case "Truck":
                            truck.Refuel(value);
                            break;
                        case "Bus":
                            bus.Refuel(value);
                            break;
                    }
                else if (command == "DriveEmpty")
                    bus.DriveEmpty(value);
            }
        }
        private static void IO(Car car, Truck truck, Bus bus)
        {
            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
            Console.WriteLine(bus.ToString());
        }
    }
}
