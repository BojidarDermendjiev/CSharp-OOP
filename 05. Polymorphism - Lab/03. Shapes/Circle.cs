using System;

namespace Shapes
{
    public class Circle : Shapes
    {
        private double radius;
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Radius { get => radius; private set => radius = value; }
        public override double CalculateArea()
            => Math.PI * Math.Pow(radius, 2);
        public override double CalculatePerimeter()
            => 2 * Math.PI * radius;
        public override string Draw()
            => base.Draw() + this.GetType().Name;
    }
}
