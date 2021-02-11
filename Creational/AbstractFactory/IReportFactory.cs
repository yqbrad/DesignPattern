namespace AbstractFactory
{
    public interface IReportFactory
    {
        IReporter Create();
    }
}