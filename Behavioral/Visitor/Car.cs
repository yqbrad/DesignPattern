namespace Visitor
{
    public class Car: IStore
    {
        public string Name { get; set; }
        public long Price { get; set; }

        public Car(string name, long price)
        {
            Name = name;
            Price = price;
        }

        public void Visit(IVisitor visitor)
        {
            visitor.Accept(this);
        }
    }
}
