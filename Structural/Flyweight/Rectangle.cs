namespace Flyweight
{
    public class Rectangle : IShape
    {
        public string Name { get; set; } = nameof(Rectangle);

        public void GetShapeName() => System.Console.WriteLine($"This is {Name}");
    }
}