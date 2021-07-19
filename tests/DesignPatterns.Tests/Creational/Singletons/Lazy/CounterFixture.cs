using System;
using DesignPatterns.Creational.Singletons.Lazy;

namespace DesignPatterns.Tests.Creational.Singletons.Lazy
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