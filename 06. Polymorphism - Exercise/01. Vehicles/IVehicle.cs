namespace _01._Vehicles
{
    public interface IVehicle
    {
        public double FuelQuantity { get; }
        public double FuelConsumption { get; }
        public void Drive(double distance);
        public void Refuel(double litters);

    }
}
