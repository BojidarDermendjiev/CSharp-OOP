namespace _02._Vehicles_Extension
{
    using System;
    public class Truck : Vehicle
    {
        private const double REFUEL_MODIFIER = 0.95;
        private const double CONSUMPTION_INCREASE = 1.6;
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption + CONSUMPTION_INCREASE, tankCapacity) { }
        public override void Refuel(double liters)
        {
            if (liters <= 0)
                Console.WriteLine(string.Format(OutputMessages.FUEL_MUST_BE_POSSITIVE_NUMBER));
            else if (this.fuelQuantity + liters > this.tankCapacity)
                Console.WriteLine(string.Format(OutputMessages.FILL_MORE_THEN_CAPACITY, liters));
            else
                base.Refuel(liters * REFUEL_MODIFIER);
        }
    }
}
