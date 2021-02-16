namespace AbstractFactory.Reporters
{
    public class PdfReporter : IReporter
    {
        public string Report() => "pdf";
    }
}