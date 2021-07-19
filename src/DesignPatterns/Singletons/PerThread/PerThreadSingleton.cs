using System.Threading;

namespace DesignPatterns.Singletons.PerThread
{
    public class PerThreadSingleton
    {
        public int Id;

        private static readonly ThreadLocal<PerThreadSingleton> ThreadInstance = new(() => new PerThreadSingleton());

        public static PerThreadSingleton Instance => ThreadInstance.Value;

        private PerThreadSingleton()
        {
            Id = Thread.CurrentThread.ManagedThreadId;
        }
    }
}