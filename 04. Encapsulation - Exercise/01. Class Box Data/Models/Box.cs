namespace _01._Class_Box_Data.Models
{
    using System;
    using Contracts;
    using Utilities.Messages;

    public class Box : IBox
    {
        private double length;
        private double width;
        private double height;
        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }
        public double Length
        {
            get => length;
            private set
            {
                if (value <= 0)
                    throw new ArgumentException(string.Format(ExcaptionMessages.BoxParertiesCannotBeZeroOrBelow, nameof(Length)));
                length = value;
            }
        }
        public double Width
        {
            get => width;
            private set
            {
                if (value <= 0)
                    throw new ArgumentException(string.Format(ExcaptionMessages.BoxParertiesCannotBeZeroOrBelow, nameof(Width)));
                width = value;
            }
        }
        public double Height
        {
            get => height;
            private set
            {
                if (value <= 0)
                    throw new ArgumentException(string.Format(ExcaptionMessages.BoxParertiesCannotBeZeroOrBelow, nameof(Height)));
                height = value;
            }
        }
        public double LateralSurfaceArea()
            => 2 * (Length * Height) + 2 * (Width * Height);
        public double SurfaceArea()
            => 2 * (Length * Width) + 2 * (Length * Height) + 2 * (Width * Height);
        public double Volume()
            => Width * Height * Length;
        public override string ToString()
         => $"Surface Area - {SurfaceArea():f2}" + Environment.NewLine + $"Lateral Surface Area - {LateralSurfaceArea():f2}" + Environment.NewLine + $"Volume - {Volume():f2}";
    }
}
