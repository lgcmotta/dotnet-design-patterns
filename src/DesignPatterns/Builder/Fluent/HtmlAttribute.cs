namespace DesignPatterns.Builder.Fluent
{
    public class HtmlAttribute
    {
        public string Key { get; set; }

        public string Value { get; set; }

        public override string ToString()
        {
            return string.IsNullOrEmpty(Key) || string.IsNullOrEmpty(Value) ? string.Empty : $"{Key}=\"{Value}\"";
        }
    }
}