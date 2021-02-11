namespace Singleton
{
    public class LogManager2
    {
        private static Logger _logger;
        private static readonly object o = new object();

        public static Logger Instance
        {
            get
            {
                lock (o)
                    return _logger ??= new Logger();
            }
        }
    }
}