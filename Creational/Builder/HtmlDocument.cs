namespace Builder
{
    public class HtmlDocument
    {
        public string Title { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
        public string Footer { get; set; }

        public override string ToString() => $"{Title} \n{Header} \n{Body} \n{Footer}";
    }
}