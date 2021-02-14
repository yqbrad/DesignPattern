using System;

namespace ChainOfResponsibility
{
    public class Program
    {
        // Avoid coupling the sender of a request to its receiver by giving more than one
        // object a chance to handle the request.
        // ارسال کننده و دریافت کننده درخواست جدا شوند
        public static void Main(string[] _)
        {
            const int price = 299;

            var bank = new Bank();
            var payPal = new PayPal();
            var bitcoin = new Bitcoin();
            bank.SetNext(payPal);
            payPal.SetNext(bitcoin);

            bank.Pay(price);

            Console.ReadKey();
        }
    }
}