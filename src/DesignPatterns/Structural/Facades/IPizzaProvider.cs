namespace DesignPatterns.Structural.Facades
{
    public interface IPizzaProvider
    {
        IPizza GetPizza(string toppings, int size);
    }
}