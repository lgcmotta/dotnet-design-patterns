namespace DesignPatterns.Structural.Facades
{
    public class Pizza : IPizza
    {
        public string Toppings { get; set; }
        public int Size { get; set; }

        public override string ToString()
        {
            return $"A pizza with {Toppings} toppings and size {Size}";
        }
    }
}