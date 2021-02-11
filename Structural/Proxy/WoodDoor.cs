using System;

namespace Proxy
{
    public class WoodDoor : IDoor
    {
        public void Close() => Console.WriteLine("Closed");

        public void Open() => Console.WriteLine("Opened");
    }
}