using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapters
{
    public class MicroUsbToLightningAdapter : ILightningChargeable
    {
        private readonly IMicroUsbChargeable _microUsbChargeable;

        public MicroUsbToLightningAdapter(IMicroUsbChargeable microUsbChargeable)
        {
            _microUsbChargeable = microUsbChargeable;
        }

        public async Task Recharge()
        {
            await _microUsbChargeable.Recharge();
        }

        public void ConnectedToLightningCable()
        {
            _microUsbChargeable.ConnectedToMicroUsbCable();
        }

        public void DisconnectedToLightingCable()
        {
            _microUsbChargeable.DisconnectedToMicroUsbCable();
        }
    }
}