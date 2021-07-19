using FluentAssertions;
using Xunit;

namespace DesignPatterns.Tests.Creational.Singletons.Lazy
{
    public class CounterTests : IClassFixture<CounterFixture>
    {
        private readonly CounterFixture _fixture;

        public CounterTests(CounterFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void CheckThatWillBeOnlyOneCounter()
        {
            var counter1 = _fixture.Counter;
            
            var counter2 = _fixture.Counter;
            
            counter2.Should().BeSameAs(counter1);
        }

        [Fact]
        public void IncrementCounter1VerifyCountInCounter2()
        {
            _fixture.Counter.Reset();

            var counter1 = _fixture.Counter;

            var counter2 = _fixture.Counter;

            counter1.Increment();

            counter2.Count.Should().Be(1);  
        }

        [Fact]
        public void DecrementCounter1VerifyCountInCounter2()
        {
            var counter1 = _fixture.Counter;

            var counter2 = _fixture.Counter;

            counter1.Decrement();

            counter2.Count.Should().Be(-1);
        }

        [Fact]
        public void ResetCounter1VerifyCountInCounter2()
        {
            var counter1 = _fixture.Counter;

            var counter2 = _fixture.Counter;

            counter1.Increment();
            
            counter1.Increment();
            
            counter1.Increment();
            
            counter1.Reset();

            counter2.Count.Should().Be(0);
        }

    }
}