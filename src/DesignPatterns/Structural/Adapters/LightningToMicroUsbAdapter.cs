using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapters
{
    public class LightningToMicroUsbAdapter : IMicroUsbChargeable
    {
        private readonly ILightningChargeable _lightningChargeable;

        public LightningToMicroUsbAdapter(ILightningChargeable lightningChargeable)
        {
            _lightningChargeable = lightningChargeable;
        }

        public async Task Recharge()
        {
            await _lightningChargeable.Recharge();
        }

        public void ConnectedToMicroUsbCable()
        {
            _lightningChargeable.ConnectedToLightningCable();
        }

        public void DisconnectedToMicroUsbCable()
        {
            _lightningChargeable.DisconnectedToLightingCable();
        }
    }
}