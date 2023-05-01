namespace _02._Vehicles_Extension
{
    using System;
    public class Vehicle : IVehicle
    {
        protected double fuelQuantity;
        protected double fuelConsumption;
        protected double tankCapacity;
        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.fuelConsumption = fuelConsumption;
            this.tankCapacity = tankCapacity;
            if(fuelQuantity <= tankCapacity)
            this.fuelQuantity = fuelQuantity;
        }
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
        public virtual void Refuel(double liters)
        {
            if (liters <= 0)
                Console.WriteLine(string.Format(OutputMessages.FUEL_MUST_BE_POSSITIVE_NUMBER));
            else if (this.fuelQuantity + liters > this.tankCapacity)
                Console.WriteLine(string.Format(OutputMessages.FILL_MORE_THEN_CAPACITY, liters));
            else
                this.fuelQuantity += liters;
        }
        public override string ToString()
         => string.Format(OutputMessages.VEHICLE_TO_STRING, this.GetType().Name, fuelQuantity);
    }
}
