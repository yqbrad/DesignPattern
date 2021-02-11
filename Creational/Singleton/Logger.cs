using System;

namespace Singleton
{
    public class Logger
    {
        private readonly string key = Guid.NewGuid().ToString("N");

        public void Log() => Console.WriteLine(key);
    }
}