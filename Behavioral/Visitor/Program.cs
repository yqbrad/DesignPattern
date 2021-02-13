using System;

namespace Visitor
{
    class Program
    {
        // Represent an operation to be performed on the elements of an object structure.
        // Visitor lets you define a new operation without changing the classes of the elements on which it operates.
        //بدون تغییر آبجکت به آن یک عملیات جدید اضافه کرد
        public static void Main(string[] _)
        {
            IStore car = new Car("pride",10000000000000);
            car.Visit(new PriceVisitor());
            
            Console.ReadKey();
        }
    }
}