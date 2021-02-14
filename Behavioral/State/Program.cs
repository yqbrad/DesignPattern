using System;

namespace State
{
    public class Program
    {
        // Allow an object to alter its behavior when its internal state changes.
        // The object will appear to change its class.
        // به یک آبجکت اجازه میدهد رفتار داخلی خودش را تغییر دهد
        public static void Main(string[] _)
        {
            var editor = new Editor();
            editor.Write("Hi Mohammad");

            editor.SetState(new UpperWrite());
            editor.Write("Hi Mohammad");

            editor.SetState(new LowerWrite());
            editor.Write("Hi Mohammad");

            Console.ReadKey();
        }
    }
}