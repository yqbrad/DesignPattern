namespace Bridge
{
    public interface IWebPage
    {
        ITheme Theme { get; set; }
        void GetContent();
    }
}