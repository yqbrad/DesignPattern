using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var defaultReporter = ReportFactory.Create();
            Console.WriteLine(defaultReporter.Report());

            var jsonReporter = ReportFactory.Create(ReportFormat.Json);
            Console.WriteLine(jsonReporter.Report());
            
            Console.ReadKey();
        }
    }
}
