using System;

namespace TemplateMethod
{
    class Program
    {
        //Define the skeleton of an algorithm in an operation, deferring some steps to subclasses.
        // یک اسکلت از یک الگوریتم داخل یک عملیات تعریف کنید که بتوانید مراحل آن را تغییر دهید
        public static void Main(string[] _)
        {
            var b = new AppBuilder();
            b.Build();

            Console.ReadKey();
        }
    }
}
