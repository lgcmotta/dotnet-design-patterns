namespace DesignPatterns.Structural.Composites
{
    public class Leaf : IComponent
    {
        public string Operation()
        {
            return nameof(Leaf);
        }
    }
}