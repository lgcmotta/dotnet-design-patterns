namespace DesignPatterns.Structural.Facades
{
    public class PizzaProvider : IPizzaProvider
    {
        public IPizza GetPizza(string toppings, int size)
        {
            return new Pizza { Toppings = toppings, Size = size };
        }
    }
}