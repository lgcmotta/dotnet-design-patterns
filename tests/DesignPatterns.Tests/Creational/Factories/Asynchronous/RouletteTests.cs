using System.Drawing;
using System.Threading.Tasks;
using DesignPatterns.Creational.Factories.Asynchronous;
using FluentAssertions;
using Xunit;

namespace DesignPatterns.Tests.Creational.Factories.Asynchronous
{
    public class RouletteTests
    {
        [Fact]
        public async Task TurnTheRoulette()
        {
            var (color, number) = await Roulette.Turn();

            var possibleColors = new[] { Color.Green, Color.Black, Color.Red };

            possibleColors.Should().Contain(color);
                
            number.Should().BeGreaterOrEqualTo(0).And.BeLessOrEqualTo(32);
        }
    }
}