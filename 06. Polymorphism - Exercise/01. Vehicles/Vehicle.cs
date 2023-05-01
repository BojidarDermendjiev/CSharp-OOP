namespace _01._Vehicles
{
    using System;
    public class Vehicle : IVehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.fuelQuantity = fuelQuantity;
            this.fuelConsumption = fuelConsumption;
        }
        public double FuelQuantity { get => fuelQuantity; private set => fuelQuantity = value; }
        public double FuelConsumption { get => fuelConsumption; private set => fuelConsumption = value; }

        public virtual void Drive(double distance)
        {
            var newFuelAmount = this.fuelQuantity - this.fuelConsumption * distance;
            if (newFuelAmount < 0)
                Console.WriteLine(string.Format(OutputMessages.VEHICLE_NEED_REFUELONG, this.GetType().Name));
            else
            {
                fuelQuantity = newFuelAmount;
                Console.WriteLine(string.Format(OutputMessages.VEHICLE_TRAVEL, this.GetType().Name, distance));
            }
        }
        public virtual void Refuel(double litters)
         => fuelQuantity += litters;
        public override string ToString()
         => string.Format(OutputMessages.VEHICLE_TO_STRING, this.GetType().Name, fuelQuantity);
    }
}
