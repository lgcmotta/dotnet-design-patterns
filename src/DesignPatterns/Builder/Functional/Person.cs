namespace DesignPatterns.Builder.Functional
{
    public class Person
    {
        public string Name { get; set; }

        public string Position { get; set; }

        public override string ToString() => $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
    }
}