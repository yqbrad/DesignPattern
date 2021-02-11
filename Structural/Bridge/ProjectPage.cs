using System;

namespace Bridge
{
    public class ProjectPage : IWebPage
    {
        public ITheme Theme { get; set; }
        public ProjectPage(ITheme theme) => Theme = theme;

        public void GetContent() => Console.WriteLine($"Project Content:{Theme.GetColor()}");
    }
}
