namespace DesignPatterns.Factories.Abstract
{
    public interface IHotDrinkFactory
    {
        IHotDrink Prepare(int amount);
    }
}