using System;

namespace Command
{
    class Program
    {
        //Avoid coupling the sender of a request to its receiver by giving more than one 
        //object chance to handle the request.
        static void Main(string[] _)
        {
            var lamp = new Lamp();
            var turnOff = new TurnOff(lamp);
            var turnOn = new TurnOn(lamp);

            var remote = new RemoteControl();
            remote.Submit(turnOff);
            remote.Submit(turnOn);

            Console.ReadKey();
        }
    }
}