using DesignPatterns.Singletons.MonoState;
using FluentAssertions;
using Xunit;

namespace DesignPatterns.Tests.Singletons.MonoState
{
    public class MonoStateTests
    {
        [Fact]
        public void CheckThatAllChangeInOneInstanceWillBeReflectedToOthers()
        {
            var mono1 = new MonoStateSingleton { State = false };
            var mono2 = new MonoStateSingleton { State = false };
            var mono3 = new MonoStateSingleton { State = true };

            mono1.State.Should().BeTrue();
            mono2.State.Should().BeTrue();
            mono3.State.Should().BeTrue();
        }
    }
}