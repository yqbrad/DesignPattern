using AbstractFactory.Reporters;

namespace AbstractFactory
{
    public class XmlReportFactory : IReportFactory
    {
        public IReporter Create() => new XmlReporter();
    }
}