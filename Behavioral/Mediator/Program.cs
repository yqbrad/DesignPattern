using System;

namespace Mediator
{
    class Program
    {
        //Define an object that encapsulates how a set of objects interact.
        static void Main(string[] _)
        {
            var chatRoom = new ChatRoom();
            var mohammad = new User("Mohammad", chatRoom);
            mohammad.SendMessage("hi");

            Console.ReadKey();
        }
    }
}