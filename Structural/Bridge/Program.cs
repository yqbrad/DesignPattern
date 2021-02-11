using System;

namespace Bridge
{
    class Program
    {
        //Decouple an abstraction from its implementation so that the two can very independently.
        static void Main(string[] _)
        {
            IWebPage about = new AboutPage(new DarkTheme());
            IWebPage proj = new ProjectPage(new LightTheme());

            about.GetContent();
            proj.GetContent();

            Console.ReadLine();
        }
    }
}