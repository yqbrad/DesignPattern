using AbstractFactory.Reporters;

namespace AbstractFactory
{
    public class PdfReportFactory : IReportFactory
    {
        public IReporter Create() => new PdfReporter();
    }
}