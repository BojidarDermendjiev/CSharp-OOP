namespace _04._Need_for_Speed
{
    public class Vehicle
    {
        private int horsePower;
        private double fuel;
        private double defaultFuelConsumption;
        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
            DefaultFuelConsumption = 1.25;
        }
        public int HorsePower { get => horsePower; set => horsePower = value; }
        public double Fuel { get => fuel; set => fuel = value; }
        public double DefaultFuelConsumption { get => defaultFuelConsumption; set => defaultFuelConsumption = value; }
        public double FuelConsumption { get => DefaultFuelConsumption; }
        public virtual void Drive(double distance) 
        {
            Fuel -= distance * FuelConsumption;
        }
    }
}
