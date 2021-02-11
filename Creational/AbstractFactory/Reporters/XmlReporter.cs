using AbstractFactory;

namespace FactoryMethod.Reporters
{
    public class XmlReporter : IReporter
    {
        public string Report() => "xml";
    }
}