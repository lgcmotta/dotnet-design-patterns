using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Creational.Builders
{
    public abstract class FunctionalBuilder<TSubject, TSelf> : IFunctionalBuilder<TSubject, TSelf>
        where TSubject : class, new()
        where TSelf : FunctionalBuilder<TSubject, TSelf>
    {
        private List<Func<TSubject, TSubject>> _functions = new();

        public virtual TSelf Clear()
        {
            _functions?.Clear();
            return this as TSelf;
        }

        public virtual TSubject Build() => _functions.Aggregate(new TSubject(), (subject, function) => function(subject));

        protected virtual TSelf AppendAction(Action<TSubject> action)
        {
            _functions.Add(subject =>
            {
                action(subject);
                return subject;
            });

            return this as TSelf;
        }

        public virtual void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing) return;
            
            _functions.Clear();
            _functions = null;
        }
    }
}