namespace Singleton
{
    public class LogManager1
    {
        private static Logger _logger;

        public static Logger Instance => _logger ??= new Logger();
    }
}