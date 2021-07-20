using System;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapters
{
    public class AndroidPhone : Phone, IMicroUsbChargeable
    {
        public async Task Recharge()
        {
            if (!CableConnected)
            {
                Console.WriteLine("Please, connect the micro usb cable to charge your Android phone.");
                return;
            }

            Console.WriteLine("Android is recharging...");
            await Task.Delay(10000);
            Recharged = true;
            Console.WriteLine("Android battery is at 100%!");
        }

        public void ConnectedToMicroUsbCable()
        {
            CableConnected = true;
        }

        public void DisconnectedToMicroUsbCable()
        {
            CableConnected = false;
        }
    }
}