using System;

namespace Mediator.Sample2
{
    public class ColleagueB: Colleague
    {
        public ColleagueB(Mediator mediator, string name)
            : base(mediator, name){ }

        public override void Receive(string message, string from)
        {
            if (!string.Equals(from, Name))
                Console.WriteLine(Name + " received from " + from + ": " + message);
        }
    }
}