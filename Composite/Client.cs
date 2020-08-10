using System;

namespace Composite
{
    public class Client
    {
        public static void Main()
        {
            var el1 = new SimpleHTMLElement("Header", "h1");
            var el2 = new SimpleHTMLElement("Paragraph", "p");
            var el3 = new HTMLElement("body");
            el3.Add(el1);
            el3.Add(el2);
            var el4 = new HTMLElement("head");
            var el5 = new SimpleHTMLElement("Title", "title");
            el4.Add(el5);
            var el6 = new HTMLElement("html");
            el6.Add(el4);
            el6.Add(el3);

            Console.WriteLine(el6.Generate());
        }
    }
}
