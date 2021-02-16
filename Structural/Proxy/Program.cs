using System;

namespace Proxy
{
    class Program
    {
        //Provide a placeholder for another object to control access to it.
        static void Main(string[] _)
        {
            var door = new SecretDoor(new WoodDoor());
            door.Open("askldjf");

            door.Open("key");
            door.Close();

            Console.ReadKey();
        }
    }
}