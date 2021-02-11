using AbstractFactory;

namespace FactoryMethod.Reporters
{
    public class PdfReporter : IReporter
    {
        public string Report() => "pdf";
    }
}