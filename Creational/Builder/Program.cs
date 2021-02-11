using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] _)
        {
            var htmlDoc = new HtmlDocumentBuilder()
                .SetTitle("title")
                .SetHeader("header")
                .SetBody("body")
                .SetFooter("footer")
                .Build();

            Console.WriteLine(htmlDoc.ToString());
            Console.ReadLine();
        }
    }
}