using System;

namespace Singleton
{
    public class LogManager3
    {
        private static Lazy<Logger> _lazyLogger = new Lazy<Logger>(CreateLogger, true);

        public static Logger Instance => _lazyLogger.Value;

        private static Logger CreateLogger() => new Logger();
    }
}