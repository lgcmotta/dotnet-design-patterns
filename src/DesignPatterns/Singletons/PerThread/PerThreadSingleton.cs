using System.Threading;

namespace DesignPatterns.Singletons.PerThread
{
    public class PerThreadCounter
    {
        private int _currentCount = 0;

        private static readonly ThreadLocal<PerThreadCounter> LazyCounter = new(() => new PerThreadCounter());

        public static PerThreadCounter Instance => LazyCounter.Value;

        private PerThreadCounter()
        {

        }

        public void Increment() => _currentCount++;

        public void Decrement() => _currentCount--;

        public void Reset() => _currentCount = 0;

        public int Count => _currentCount;
    }
}