using System.Threading.Tasks;
using DesignPatterns.Singletons.PerThread;
using Xunit;

namespace DesignPatterns.Tests.Singletons.PerThread
{
    public class PerThreadSingletonTests
    {
        [Fact]
        public void CheckIfDifferentThreadsWillBeDifferentInstances()
        {
            var id1 = 0;
            
            var id2 = 0;

            var task1 = Task.Factory.StartNew(() =>
            {
                id1 = PerThreadSingleton.Instance.Id;
            });
            
            var task2 = Task.Factory.StartNew(() =>
            {
                id2 = PerThreadSingleton.Instance.Id;
            });

            Task.WaitAll(task1, task2);

            Assert.NotEqual(id1, id2);
        }
    }   
}