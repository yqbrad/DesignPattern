namespace Prototype
{
    public class Benz : ICar
    {
        public string Model { get; set; }

        public Benz(string model) => Model = model;

        public ICar Clone() => MemberwiseClone() as ICar;
    }
}