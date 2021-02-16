using System;

namespace Builder
{
    class Program
    {
        //Separate the construction of a complex object from its representation.
        //for creating complex objects that have multiple parts.
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