namespace DesignPatterns.Structural.Facades
{
    public class RestaurantFacade
    {
        private readonly IPizzaProvider _pizzaProvider;
        private readonly IHamburgerProvider _hamburgerProvider;

        public RestaurantFacade(IPizzaProvider pizzaProvider, IHamburgerProvider hamburgerProvider)
        {
            _pizzaProvider = pizzaProvider;
            _hamburgerProvider = hamburgerProvider;
        }

        public IPizza GetLargePepperoniPizza() => _pizzaProvider.GetPizza("Pepperoni", 50);

        public IPizza GetSmallCheesePizza() => _pizzaProvider.GetPizza("Cheese", 25);

        public IHamburger GetTripleAustralianBurger() => _hamburgerProvider.GetHamburger(3, "Australian");

        public IHamburger GetSimpleBurger() => _hamburgerProvider.GetHamburger(1, "White");
    }
}