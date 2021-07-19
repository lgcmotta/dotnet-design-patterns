using DesignPatterns.Creational.Factories.Abstract;
using FluentAssertions;
using Xunit;

namespace DesignPatterns.Tests.Creational.Factories.Abstract
{
    public class HotDrinkMachineTests
    {
        [Fact]
        public void PrepareACoffee()
        {
            var hotDrinkMachine = new HotDrinkMachine();

            var coffee= hotDrinkMachine.GetDrink("Coffee", 100);

            coffee.Should().NotBeNull().And.BeOfType<Coffee>();
        }

        [Fact]
        public void PrepareATea()
        {
            var hotDrinkMachine = new HotDrinkMachine();

            var tea = hotDrinkMachine.GetDrink("Tea", 100);

            tea.Should().NotBeNull().And.BeOfType<Tea>();
        }
    }
}