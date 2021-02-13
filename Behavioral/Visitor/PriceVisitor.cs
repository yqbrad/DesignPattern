using System;

namespace Visitor
{
    public class PriceVisitor: IVisitor
    {
        public void Accept(IStore store)
        {
            var car = store as Car;
            const int discount = 1000;

            Console.WriteLine($"The {car.Name}, price is {car.Price - discount}.");
        }
    }
}