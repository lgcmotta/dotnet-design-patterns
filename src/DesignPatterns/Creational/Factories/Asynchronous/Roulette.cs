using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factories.Asynchronous
{
    public class Roulette
    {
        private static readonly List<(Color color, int number)> Slots = new()
        {
            (Color.Green, 0),
            (Color.Red, 32),
            (Color.Black, 15),
            (Color.Red, 19),
            (Color.Black, 4),
            (Color.Red, 21),
            (Color.Black, 2),
            (Color.Red, 25),
            (Color.Black, 17),
            (Color.Red, 34),
            (Color.Black, 6),
            (Color.Red, 27),
            (Color.Black, 13),
            (Color.Red, 36),
            (Color.Black, 11),
            (Color.Red, 30),
            (Color.Black, 8),
            (Color.Red, 23),
            (Color.Black, 10),
            (Color.Red, 5),
            (Color.Black, 24),
            (Color.Red, 16),
            (Color.Black, 33),
            (Color.Red, 1),
            (Color.Black, 20),
            (Color.Red, 14),
            (Color.Black, 31),
            (Color.Red, 9),
            (Color.Black, 22),
            (Color.Red, 18),
            (Color.Black, 29),
            (Color.Red, 7),
            (Color.Black, 28),
            (Color.Red, 12),
            (Color.Black, 35),
            (Color.Red, 3),
            (Color.Black, 26)
        };

        private Roulette()
        {
            
        }

        /// <summary>
        /// You'll have to wait for the wheel to stop. Are you lucky?
        /// </summary>
        /// <returns></returns>
        public static async Task<(Color color, int number)> Turn()
        {
            await Task.Delay(10000);
           
            var selectedNumber = new Random().Next(0, 33);

            return Slots.FirstOrDefault(slot => slot.number == selectedNumber);
        }
    }
}