namespace DesignPatterns.Creational.Factories.Abstract
{
    public interface IHotDrinkFactory
    {
        IHotDrink Prepare(int amount);
    }
}