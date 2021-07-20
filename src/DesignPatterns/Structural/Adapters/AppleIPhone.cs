using System;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapters
{
    public class AppleIPhone : Phone, ILightningChargeable
    {
        public async Task Recharge()
        {
            if (!CableConnected)
            {
                Console.WriteLine("Please, connect the lightning cable to recharge your Iphone.");
                return;
            }

            Console.WriteLine("Iphone is recharging...");
            await Task.Delay(10000);
            Recharged = true;
            Console.WriteLine("Iphone battery is at 100%!");
        }

        public void ConnectedToLightningCable()
        {
            CableConnected = true;
        }

        public void DisconnectedToLightingCable()
        {
            CableConnected = false;
        }
    }
}