namespace Shapes
{
    public abstract class Shapes : IShapes
    {
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
        public virtual string Draw()
            => $"Drawing ";
    }
}
