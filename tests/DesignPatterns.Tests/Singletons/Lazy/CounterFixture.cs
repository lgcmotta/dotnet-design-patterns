using System;
using DesignPatterns.Singletons.Lazy;

namespace DesignPatterns.Tests.Singletons.Lazy
{
    public class CounterFixture : IDisposable
    {
        public Counter Counter { get; set; }

        public CounterFixture()
        {
            Counter = Counter.Instance;
        }

        public void Dispose()
        {
            Counter = null;
        }
    }
}