namespace DesignPatterns.Structural.Facades
{
    public class Hamburger : IHamburger
    {
        public int PattiesCount { get; set; }
        public string BreadType { get; set; }

        public override string ToString()
        {
            return $"Hamburger with {PattiesCount} patties and {BreadType} bread";
        }
    }
}