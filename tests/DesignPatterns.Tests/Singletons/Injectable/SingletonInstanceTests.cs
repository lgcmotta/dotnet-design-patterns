using System;
using DesignPatterns.Singletons.Injectable;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace DesignPatterns.Tests.Singletons.Injectable
{
    public class SingletonInstanceTests
    {
        [Fact]
        public void AlwaysTheSameInjectableInstance()
        {
            var serviceCollection = new ServiceCollection();
            
            serviceCollection.AddSingleton<IInjectableSingleton>(_ => new InjectableSingleton(Guid.NewGuid()));
            
            var serviceProvider = serviceCollection.BuildServiceProvider();

            var injectable1 = serviceProvider.GetRequiredService<IInjectableSingleton>();
            
            var injectable2 = serviceProvider.GetRequiredService<IInjectableSingleton>();

            injectable1.Should().BeSameAs(injectable2);
            
            Assert.Equal(injectable1.AlwaysSameGuid(), injectable2.AlwaysSameGuid());
        }
    }
}