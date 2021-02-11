using System;

namespace Facade
{
    class Program
    {
        //Facade defines a higher-level interface that makes the subsystem easier to use.
        static void Main(string[] _)
        {
            var computerFacade = new ComputerFacade(new Computer());

            computerFacade.TurnOn();
            Console.WriteLine("\n");
            computerFacade.TurnOff();

            Console.ReadKey();
        }
    }
}