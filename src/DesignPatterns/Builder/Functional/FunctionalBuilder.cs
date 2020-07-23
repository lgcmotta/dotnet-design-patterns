using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Builder.Functional
{
    public class FunctionalBuilder<TSubject, TSelf>
        where TSubject : new()
        where TSelf : FunctionalBuilder<TSubject, TSelf>
    {
        private readonly List<Func<TSubject, TSubject>> _actions = new List<Func<TSubject, TSubject>>();

        public TSubject Build() => _actions.Aggregate(new TSubject(), (subject, function) => function(subject));

        public TSelf AppendAction(Action<TSubject> action) => AddAction(action);

        private TSelf AddAction(Action<TSubject> action)
        {
            _actions.Add(subject =>
            {
                action(subject);
                return subject;
            }); 

            return this as TSelf;
        }
    }
}