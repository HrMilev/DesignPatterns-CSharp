using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class HTMLElement : IHTMLComposable
    {
        private readonly IList<IHTMLComposable> elements;
        private readonly int indent = 2;
        private readonly StringBuilder stringBuilder;
        private readonly string tag;

        public HTMLElement(string tag)
        {
            stringBuilder = new StringBuilder();
            elements = new List<IHTMLComposable>();
            this.tag = tag;
        }

        public void Add(IHTMLComposable element)
        {
            elements.Add(element);
        }

        public string Generate(int indent = 0)
        {
            stringBuilder.AppendLine($"{new string(' ', indent)}<{tag}>");
            foreach (var el in elements)
            {
                stringBuilder.AppendLine($"{new string(' ', indent + 2 )}{el.Generate(indent + 2)}");
            }
            stringBuilder.AppendLine($"{new string(' ', indent)}</{tag}>");

            return stringBuilder.ToString().Trim();
        }
    }
}
