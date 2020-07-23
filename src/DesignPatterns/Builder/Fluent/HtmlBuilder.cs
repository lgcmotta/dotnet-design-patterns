using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Builder.Fluent
{
    public class HtmlBuilder
    {
        private HtmlElement _head;

        private HtmlElement _body;
        
        public HtmlElement Root { get; private set; }

        private static HtmlElement CreateRoot(string tagName) => new HtmlElement(tagName);

        public HtmlBuilder() => Reset();
        
        private static void AppendHtmlChild(HtmlElement root, string tag, string value, IEnumerable<(string key, string value)> attributes)
        {
            root.Children.Add(new HtmlElement(tag, value) { Attributes = AppendElementAttributes(attributes) });
        }
        
        private static List<HtmlAttribute> AppendElementAttributes(IEnumerable<(string key, string value)> attributes)
        {
            return attributes is null
                ? new List<HtmlAttribute>()
                : attributes.Select(attribute => new HtmlAttribute
                    { Key = attribute.key, Value = attribute.value }).ToList();
        }

        private void Reset()
        {
            _head = CreateRoot("head");
            _body = CreateRoot("body");
            Root = CreateRoot("html");
            Root.Children.Add(_head);
            Root.Children.Add(_body);
        }

        public HtmlBuilder AppendHeadChild(string tag, string value, IEnumerable<(string key, string value)> attributes = null)
        {
            AppendHtmlChild(_head, tag, value, attributes);

            return this;
        }

        public HtmlBuilder AppendBodyChild(string tag, string value, IEnumerable<(string key, string value)> attributes = null)
        {
            AppendHtmlChild(_body, tag, value, attributes);

            return this;
        }
        
        public HtmlBuilder Clear()
        {
            Reset();
            return this;
        }

        public string Build() => ToString();

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            // ReSharper disable once StringLiteralTypo
            stringBuilder.Append("<!DOCTYPE html>\n");

            return stringBuilder.Append($"{Root}\n").ToString();
        }
    }
}