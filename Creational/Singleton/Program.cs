using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] _)
        {
            //Method1();
            //Method2();
            Method3();

            Console.ReadLine();
        }

        private static void Method1()
        {
            var logger1 = LogManager1.Instance;
            logger1.Log();

            var logger2 = LogManager1.Instance;
            logger2.Log();
        }

        private static void Method2()
        {
            var logger1 = LogManager2.Instance;
            logger1.Log();

            var logger2 = LogManager2.Instance;
            logger2.Log();
        }

        private static void Method3()
        {
            var logger1 = LogManager3.Instance;
            logger1.Log();

            var logger2 = LogManager3.Instance;
            logger2.Log();
        }
    }
}