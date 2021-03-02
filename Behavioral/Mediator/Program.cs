using System;
using Mediator.Sample1;
using Mediator.Sample2;

namespace Mediator
{
    class Program
    {
        //Define an object that encapsulates how a set of objects interact.
        static void Main(string[] _)
        {
            //Sample1();
            Sample2();

            Console.ReadKey();
        }

        static void Sample1()
        {
            var chatRoom = new ChatRoom();
            var mohammad = new User("Mohammad", chatRoom);
            mohammad.SendMessage("hi");
        }

        static void Sample2()
        {
            Sample2.Mediator m = new Sample2.Mediator();
            Colleague head1 = new Colleague(m, "John");
            ColleagueB branch1 = new ColleagueB(m, "David");
            Colleague head2 = new Colleague(m, "Lucy");
            
            head1.Send("Meeting on Tuesday, please all ack");
            branch1.Send("Ack");
            
            m.Block(branch1.Receive);
            head1.Send("Still awaiting some Acks");
            head2.Send("Ack");
            
            m.Unblock(branch1.Receive);
            head1.Send("Thanks all");
        }
    }
}