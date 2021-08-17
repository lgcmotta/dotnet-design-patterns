namespace DesignPatterns.Structural.Facades
{
    public class HamburgerProvider : IHamburgerProvider
    {
        public IHamburger GetHamburger(int pattiesCount, string breadType)
        {
            return new Hamburger { BreadType = breadType, PattiesCount = pattiesCount };
        }
    }
}