using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Creational.Factories.Abstract
{
    public class HotDrinkMachine
    {
        private readonly List<(string drink, IHotDrinkFactory factory)> _factories = new ();

        public HotDrinkMachine()
        {
            foreach (var type in typeof(HotDrinkMachine).Assembly.FindIHotDrinkFactoryImplementationTypes())
            {
                _factories.Add((type.Name.Replace("Factory", string.Empty), (IHotDrinkFactory)Activator.CreateInstance(type)));
            }
        }

        public void ListAvailableDrinks()
        {
            for (var index = 0; index < _factories.Count; index++)
            {
                var tuple = _factories[index];
                
                Console.WriteLine($"{index}: {tuple.drink}");
            }
        }

        public IHotDrink GetDrink(string drink, int amount)
        {
            return _factories.All(f => f.drink != drink) && !string.IsNullOrEmpty(drink)
                ? null
                : _factories.First(f => f.drink == drink).factory.Prepare(amount);
        }
    }
}