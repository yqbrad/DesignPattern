using System;

namespace SimpleFactory
{
    public class Program
    {
        //A factory is an object for creating other objects.

        //    What is problem?!
        //      * Many object instantiation in application.
        //      * Change all place that object instanced.
        //      * Instance logic isn't hide.

        //** It violates Open/Close Principal (OCP)
        //به علت اینکه اگر یک فرمت جدید اضافه شود کد تغییر میکند، این اصل را نقض میکند
        public static void Main(string[] _)
        {
            var jsonReporter = ReportFactory.Create(ReportFormat.Json);

            Console.WriteLine(jsonReporter.Report());
            Console.ReadKey();
        }
    }
}