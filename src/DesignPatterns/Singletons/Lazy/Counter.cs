using System;

namespace DesignPatterns.Singletons.Lazy
{
    public class Counter
    {
        private static int _currentCount = 0;

        private static readonly Lazy<Counter> LazyCounter = new (() => new Counter());

        public static Counter Instance => LazyCounter.Value;

        private Counter()   
        {

        }

        public void Increment() => _currentCount++;

        public void Decrement() => _currentCount--;

        public void Reset() => _currentCount = 0;

        public int Count => _currentCount;
    }
}