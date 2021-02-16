using System;

namespace AbstractFactory
{
    public class Program
    {
        //Provide an interface for creating families of related objects without specifying their concrete classes.
        static void Main(string[] _)
        {
            IReportFactory xmlReportFactory = new XmlReportFactory();
            var xmlReporter = xmlReportFactory.Create();
            Console.WriteLine(xmlReporter.Report());

            IReportFactory pdfReportFactory = new PdfReportFactory();
            var pdfReporter = pdfReportFactory.Create();
            Console.WriteLine(pdfReporter.Report());

            Console.ReadKey();
        }
    }
}