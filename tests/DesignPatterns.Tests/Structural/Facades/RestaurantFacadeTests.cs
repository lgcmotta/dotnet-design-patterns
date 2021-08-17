using DesignPatterns.Structural.Facades;
using Xunit;

namespace DesignPatterns.Tests.Structural.Facades
{
    public class RestaurantFacadeTests
    {
        private readonly RestaurantFacade _restaurantFacade = new(new PizzaProvider(), new HamburgerProvider());

        [Fact]
        public void GetALargePepperoniPizzaShouldGetItLargeAndWithPepperoni()
        {
            var pepperoniPizza = _restaurantFacade.GetLargePepperoniPizza();

            Assert.Equal("A pizza with Pepperoni toppings and size 50", pepperoniPizza.ToString());
        }

        [Fact]
        public void GetASmallCheesePizzaShouldGetItSmallAndWithCheese()
        {
            var cheesePizza = _restaurantFacade.GetSmallCheesePizza();

            Assert.Equal("A pizza with Cheese toppings and size 25", cheesePizza.ToString());
        }

        [Fact]
        public void GetATripleAustralianBurgerShouldGetItWithThreePattiesAndAustralianBread()
        {
            var australianBurger = _restaurantFacade.GetTripleAustralianBurger();

            Assert.Equal($"Hamburger with 3 patties and Australian bread", australianBurger.ToString());
        }

        [Fact]
        public void GetSimpleBurgerShouldGetItWithOnePattyAndWhiteBread()
        {
            var simpleBurger = _restaurantFacade.GetSimpleBurger();

            Assert.Equal("Hamburger with 1 patties and White bread", simpleBurger.ToString());
        }
    }
}