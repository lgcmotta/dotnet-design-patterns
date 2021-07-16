using DesignPatterns.Factories.Abstract;
using FluentAssertions;
using Xunit;

namespace DesignPatterns.Tests.Factories.Abstract
{
    public class HotDrinkMachineTests
    {
        [Fact]
        public void PrepareACoffee_Success()
        {
            var hotDrinkMachine = new HotDrinkMachine();

            var coffee= hotDrinkMachine.GetDrink("Coffee", 100);

            coffee.Should().NotBeNull().And.BeOfType<Coffee>();
        }

        [Fact]
        public void PrepareATea_Success()
        {
            var hotDrinkMachine = new HotDrinkMachine();

            var tea = hotDrinkMachine.GetDrink("Tea", 100);

            tea.Should().NotBeNull().And.BeOfType<Tea>();
        }
    }
}