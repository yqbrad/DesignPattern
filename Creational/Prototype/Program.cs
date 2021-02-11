using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] _)
        {
            ICar benz = new Benz("S500");

            var benz2 = benz.Clone();

            Console.WriteLine($"{benz.Model}:{benz2.Model}");
            Console.ReadLine();
        }
    }
}