using System;

namespace Mediator.Sample2
{
    public class Colleague
    {
        private readonly Mediator _mediator;
        protected readonly string Name;

        public Colleague(Mediator mediator, string name)
        {
            _mediator = mediator;
            mediator.SignOn(Receive);
            Name = name;
        }

        public virtual void Receive(string message, string from) 
            => Console.WriteLine(Name + " received from " + from + ": " + message);

        public void Send(string message)
        {
            Console.WriteLine("Send (From " + Name + "): " + message);
            _mediator.Send(message, Name);
        }
    }
}