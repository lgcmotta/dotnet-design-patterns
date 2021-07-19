using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DesignPatterns.Creational.Factories.Abstract
{
    public static class HotDrinkMachineExtensions
    {
        public static IEnumerable<Type> FindIHotDrinkFactoryImplementationTypes(this Assembly assembly)
        {
            return assembly.GetTypes()
                .Where(type => typeof(IHotDrinkFactory).IsAssignableFrom(type) && !type.IsInterface);
        }
    }
}