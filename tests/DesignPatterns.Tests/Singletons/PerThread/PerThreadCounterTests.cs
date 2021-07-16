using System.Threading.Tasks;
using DesignPatterns.Singletons.PerThread;
using FluentAssertions;
using Xunit;

namespace DesignPatterns.Tests.Singletons.PerThread
{
    public class PerThreadCounterTests
    {
        [Fact]
        public void CheckThatCounterInstancesWillBeDifferent()
        {
            PerThreadCounter counter1 = null;
            
            PerThreadCounter counter2 = null;
            
            var task1 = Task.Factory.StartNew(() =>
            {
                counter1 = PerThreadCounter.Instance;
            });
            
            var task2 = Task.Factory.StartNew(() =>
            {
                counter2 = PerThreadCounter.Instance;
            });

            Task.WaitAll(task1, task2);
            
            counter2.Should().NotBeNull();
            
            counter1.Should().NotBeNull();
            
            counter2.Should().NotBeSameAs(counter1);
        }

        [Fact]
        public void IncrementingCountersPerThreadShouldHaveDifferentResults()
        {
            var task1 = Task.Factory.StartNew(() =>
            {
               var counter1 = PerThreadCounter.Instance;
                counter1.Increment();
                counter1.Count.Should().Be(1);
            });

            var task2 = Task.Factory.StartNew(() =>
            {
                var counter2 = PerThreadCounter.Instance;
                counter2.Increment();
                counter2.Increment();
                counter2.Increment();
                counter2.Count.Should().Be(3);
            });

            Task.WaitAll(task1, task2);
        }
    }
}