using System.Threading.Tasks;
using DesignPatterns.Factories.Asynchronous;
using FluentAssertions;
using Xunit;

namespace DesignPatterns.Tests.Factories.Asynchronous
{
    public class SlothTests
    {
        [Fact]
        public async Task CreateASloth_Success()
        {
            var sloth = await Sloth.NewSloth();

            sloth.Should().NotBeNull();
        }
    }
}