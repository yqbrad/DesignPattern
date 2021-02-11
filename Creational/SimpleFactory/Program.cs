using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var jsonReporter = ReportFactory.Create(ReportFormat.Json);

            Console.WriteLine(jsonReporter.Report());
            Console.ReadKey();
        }
    }
}