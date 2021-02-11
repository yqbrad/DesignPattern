using System;

namespace Flyweight
{
    class Program
    {
        //Use sharing to support large numbers of fine-grained objects efficiently.
        static void Main(string[] _)
        {
            var factory = new ShapeFactory();
            var shape = factory.GetShape(nameof(Circle));
            shape.GetShapeName();

            shape = factory.GetShape(nameof(Circle));
            shape.GetShapeName();

            shape = factory.GetShape(nameof(Rectangle));
            shape.GetShapeName();

            shape = factory.GetShape(nameof(Rectangle));
            shape.GetShapeName();


            Console.WriteLine($"count: {factory.ShapeCount}");
            Console.ReadKey();
        }
    }
}