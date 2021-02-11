namespace Prototype
{
    public interface ICar
    {
        string Model { get; set; }
        ICar Clone();
    }
}