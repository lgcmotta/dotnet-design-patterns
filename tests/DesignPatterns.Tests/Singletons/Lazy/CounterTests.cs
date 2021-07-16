using DesignPatterns.Singletons.Lazy;
using FluentAssertions;
using Xunit;

namespace DesignPatterns.Tests.Singletons.Lazy
{
    public class CounterTests
    {
        [Fact]
        public void CheckThatWillBeOnlyOneCounter()
        {
            var counter1 = Counter.Instance;
            
            var counter2 = Counter.Instance;
            
            counter2.Should().BeSameAs(counter1);
        }

        [Fact]
        public void IncrementCounter1VerifyCountInCounter2()
        {
            var counter1 = Counter.Instance;

            var counter2 = Counter.Instance;

            counter1.Increment();

            counter2.Count.Should().Be(1);  
        }

        [Fact]
        public void DecrementCounter1VerifyCountInCounter2()
        {
            var counter1 = Counter.Instance;

            var counter2 = Counter.Instance;

            counter1.Decrement();

            counter2.Count.Should().Be(-1);
        }

        [Fact]
        public void ResetCounter1VerifyCountInCounter2()
        {
            var counter1 = Counter.Instance;

            var counter2 = Counter.Instance;

            counter1.Increment();
            
            counter1.Increment();
            
            counter1.Increment();
            
            counter1.Reset();

            counter2.Count.Should().Be(0);
        }

    }
}