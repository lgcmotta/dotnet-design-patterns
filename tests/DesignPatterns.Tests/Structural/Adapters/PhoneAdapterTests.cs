using System.Threading.Tasks;
using DesignPatterns.Structural.Adapters;
using Xunit;

namespace DesignPatterns.Tests.Structural.Adapters
{
    public class PhoneAdapterTests
    {
        [Fact]
        public async Task RechargeIphoneWithMicroUsbCable()
        {
            var iphone = new AppleIPhone();
            
            var adapter = new LightningToMicroUsbAdapter(iphone);

            adapter.ConnectedToMicroUsbCable();

            await adapter.Recharge();

            Assert.True(iphone.Recharged);
        }

        [Fact]
        public async Task RechargeAndroidPhoneWithLightningCable()
        {
            var android = new AndroidPhone();

            var adapter = new MicroUsbToLightningAdapter(android);

            adapter.ConnectedToLightningCable();

            await adapter.Recharge();

            Assert.True(android.Recharged);
        }
    }
}