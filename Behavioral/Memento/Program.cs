using System;

namespace Memento
{
    class Program
    {
        // Without violating encapsulation, capture and externalize an object's internal state
        // so that the object can ve restored to this state later.
        // بدون نقض کپسوله سازی وضعیت های یک آبجکت ذخیره شود و بتوان آنها را بازیابی نمود
        static void Main(string[] _)
        {
            var editor = new Editor();

            editor.Type("this is one");
            editor.Type("this is two");
            Console.WriteLine($"Type======> {editor.Content}");

            editor.Save();
            Console.WriteLine($"Save======> {editor.Content}");

            editor.Type("this is three");
            Console.WriteLine($"Type======> { editor.Content}");

            editor.Restore();
            Console.WriteLine($"Restore===> {editor.Content}");

            Console.ReadKey();
        }
    }
}