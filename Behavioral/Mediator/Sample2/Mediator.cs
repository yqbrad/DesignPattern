using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Sample2
{
    public class Mediator
    {
        public delegate void Callback(string message, string from);

        private Callback _respond;

        public void SignOn(Callback method)
        {
            _respond += method;
        }

        public void Block(Callback method)
        {
            _respond -= method;
        }

        public void Unblock(Callback method)
        {
            _respond += method;
        }

        public void Send(string message, string from)
        {
            _respond(message, from);
            Console.WriteLine();
        }
    }
}