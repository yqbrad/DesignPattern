namespace Flyweight
{
    public class Circle : IShape
    {
        public string Name { get; set; } = nameof(Circle);

        public void GetShapeName() => System.Console.WriteLine($"This is {Name}");
    }
}