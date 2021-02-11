namespace Builder
{
    public class HtmlDocumentBuilder
    {
        private readonly HtmlDocument htmlDocument;
        public HtmlDocumentBuilder() => htmlDocument = new HtmlDocument();

        public HtmlDocumentBuilder SetTitle(string title)
        {
            htmlDocument.Title = title;
            return this;
        }

        public HtmlDocumentBuilder SetHeader(string header)
        {
            htmlDocument.Header = header;
            return this;
        }

        public HtmlDocumentBuilder SetBody(string body)
        {
            htmlDocument.Body = body;
            return this;
        }

        public HtmlDocumentBuilder SetFooter(string footer)
        {
            htmlDocument.Footer = footer;
            return this;
        }

        public HtmlDocument Build() => htmlDocument;
    }
}