namespace DesignPatterns.Structural.Facades
{
    public interface IHamburgerProvider
    {
        IHamburger GetHamburger(int pattiesCount, string breadType);
    }
}