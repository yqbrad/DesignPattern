using System;

namespace Decorator
{
    class Program
    {
        //Attach additional responsibilities to an object dynamically.
        //Decorators provide a flexible alternative to subclassing for extending functionality.
        //اضافه کردن عملکرد جدید به آبجکت
        static void Main(string[] _)
        {
            IComponent component = new Component();
            IComponent decorator = new ComponentUppercaseDecorator(component);

            Console.WriteLine(decorator.GetInfo());
            Console.ReadLine();

            Console.ReadLine();
        }
    }
}