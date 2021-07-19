using System;

namespace DesignPatterns.Creational.Factories.Abstract
{
    public class Tea : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("This tea is nice but I'd prefer it with milk.");
        }
    }
}