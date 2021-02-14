using System;
using System.Security.Authentication;

namespace ChainOfResponsibility
{
    public class Account
    {
        private Account _alternative;
        public long Value;

        public void SetNext(Account alternative) => _alternative = alternative;

        public void Pay(long price)
        {
            if (CantPay(price))
                Console.WriteLine($"Paid {price:#,0} using {GetType().Name}");
            else if (_alternative != null)
            {
                Console.WriteLine($"Can't paid {price:#,0} using {GetType().Namespace}");
                _alternative.Pay(price);
            }
            else
                throw new InvalidCredentialException();
        }

        private bool CantPay(long price) => Value >= price;
    }
}