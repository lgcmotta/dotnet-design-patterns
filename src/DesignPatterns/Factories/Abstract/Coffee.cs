﻿using System;

namespace DesignPatterns.Factories.Abstract
{
    public class Coffee : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("This coffee is sensational!");
        }
    }
}