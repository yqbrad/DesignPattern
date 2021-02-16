using System;

namespace FactoryMethod
{
    public class Program
    {
        //Define an interface for creating an object, but lest subclasses decide which class to instantiate.
        static void Main(string[] _)
        {
            var defaultReporter = ReportFactory.Create();
            Console.WriteLine(defaultReporter.Report());

            var jsonReporter = ReportFactory.Create(ReportFormat.Json);
            Console.WriteLine(jsonReporter.Report());

            Console.ReadKey();
        }
    }
}