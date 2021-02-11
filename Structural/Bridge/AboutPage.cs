using System;

namespace Bridge
{
    public class AboutPage : IWebPage
    {
        public ITheme Theme { get; set; }
        public AboutPage(ITheme theme) => Theme = theme;

        public void GetContent() => Console.WriteLine($"About Content:{Theme.GetColor()}");
    }
}