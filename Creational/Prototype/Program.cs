using System;

namespace Prototype
{
    class Program
    {
        //Specify the kind of objects to create using a prototypical instance,
        //and create new objects by copying this prototype.
        static void Main(string[] _)
        {
            ICar benz = new Benz("S500");

            var benz2 = benz.Clone();

            Console.WriteLine($"{benz.Model}:{benz2.Model}");
            Console.ReadLine();
        }
    }
}