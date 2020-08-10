using System.Text;

namespace Composite
{
    public class SimpleHTMLElement : IHTMLComposable
    {
        private readonly StringBuilder stringBuilder;
        private readonly string content;
        private readonly string tag;

        public SimpleHTMLElement(string content, string tag)
        {
            stringBuilder = new StringBuilder();
            this.content = content;
            this.tag = tag;
        }

        public string Generate(int indent = 0)
        {
            stringBuilder.AppendLine($"{new string(' ', indent)}<{tag}>");
            stringBuilder.AppendLine($"{new string(' ', indent + 2)}{content}");
            stringBuilder.AppendLine($"{new string(' ', indent)}</{tag}>");

            return stringBuilder.ToString().Trim();
        }
    }
}
