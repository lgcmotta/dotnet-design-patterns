using DesignPatterns.Structural.Facades;
using Xunit;

namespace DesignPatterns.Tests.Structural.Facades
{
    public class RestaurantFacadeTests
    {
        [Fact]
        public void GetALargePepperoniPizzaShouldGetItLargeAndWithPepperoni()
        {
            var restaurantFacade = new RestaurantFacade(new PizzaProvider(), new HamburgerProvider());

            var pepperoniPizza = restaurantFacade.GetLargePepperoniPizza();

            Assert.Equal("A pizza with Pepperoni toppings and size 50", pepperoniPizza.ToString());
        }
    }
}