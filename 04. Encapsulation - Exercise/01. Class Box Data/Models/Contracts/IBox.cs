namespace _01._Class_Box_Data.Models.Contracts
{
    public interface IBox
    {
        public double Length { get; }
        public double Width { get; }
        public double Height { get; }
        public double SurfaceArea();
        public double LateralSurfaceArea();
        public double Volume();
    }
}
