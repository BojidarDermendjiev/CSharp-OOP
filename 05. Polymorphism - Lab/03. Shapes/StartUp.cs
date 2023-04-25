namespace Shapes
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            Circle circle = new Circle(3);
            Console.WriteLine(circle.CalculatePerimeter());
            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine(circle.Draw());
            Rectangle rectangle = new Rectangle(2, 3);
            Console.WriteLine(rectangle.CalculatePerimeter());
            Console.WriteLine(rectangle.CalculateArea());
            Console.WriteLine(rectangle.Draw());
        }
    }
}
