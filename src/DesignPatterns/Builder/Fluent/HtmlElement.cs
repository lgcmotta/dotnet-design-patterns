using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder.Fluent
{
    public class HtmlElement
    {
        private const int IndentSize = 2;

        public List<HtmlElement> Children { get; set; } = new List<HtmlElement>();

        public List<HtmlAttribute> Attributes { get; set; } = new List<HtmlAttribute>();

        public string Tag { get; set; }

        public string Value { get; set; }

        public HtmlElement(string tag, string value) : this(tag) => Value = value;

        public HtmlElement(string tag) => Tag = tag ?? throw new ArgumentNullException(nameof(tag));

        public HtmlElement()
        {
            
        }

        private string ToStringImplementation(int indent)
        {
            var stringBuilder = new StringBuilder();

            var indentLevel = CalculateIndentLevelString(indent);

            if (!HasValue() && !HasChildren())
                return SelfClosingHtmlTag(stringBuilder, indentLevel);

            OpenHtmlElementBlock(stringBuilder, indentLevel);

            if(HasValue())
            {
                stringBuilder.Append($"{Value}");
            }

            if (Children.Count > 0)
                stringBuilder.Append("\n");

            AppendHtmlChildrenElements(indent, stringBuilder);

            CloseHtmlElementBlock(stringBuilder, indentLevel);

            return stringBuilder.ToString();
        }
        
        private void OpenHtmlElementBlock(StringBuilder stringBuilder, string indentLevel)
        {
            stringBuilder.Append($"{indentLevel}<{Tag}");

            AppendAttributes(stringBuilder);

            stringBuilder.Append(">");
        }

        private void CloseHtmlElementBlock(StringBuilder stringBuilder, string indentLevel) => stringBuilder.Append($"{(!HasValue() ? indentLevel : string.Empty)}</{Tag}>\n");

        private void AppendHtmlChildrenElements(int indent, StringBuilder stringBuilder)
        {
            foreach (var child in Children)
                stringBuilder.Append($"{child.ToStringImplementation(indent + 1)}");
        }

        private string SelfClosingHtmlTag(StringBuilder stringBuilder, string indentLevel)
        {
            stringBuilder.Append($"{indentLevel}<{Tag}");

            AppendAttributes(stringBuilder);

            return stringBuilder.Append(" />").ToString();

        }

        private void AppendAttributes(StringBuilder stringBuilder)
        {
            if (!HasAttributes())
                return;

            stringBuilder.Append(' ').Append(string.Join(' ', Attributes));
        }

        private bool HasAttributes() => !(Attributes is null || Attributes.Count == 0);

        private bool HasValue() => !string.IsNullOrEmpty(Value);

        private bool HasChildren() => !(Children is null || Children.Count == 0);

        private static string CalculateIndentLevelString(int indent) => new string(' ', IndentSize * indent);

        public override string ToString() => ToStringImplementation(0);
    }
}