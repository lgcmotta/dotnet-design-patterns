using System;

namespace DesignPatterns.Creational.Builders
{
    public interface IFunctionalBuilder<out TSubject, out TSelf> : IDisposable
        where TSubject : class, new ()
        where TSelf : IFunctionalBuilder<TSubject, TSelf>
    {
        TSelf Clear();

        TSubject Build();
    }
}