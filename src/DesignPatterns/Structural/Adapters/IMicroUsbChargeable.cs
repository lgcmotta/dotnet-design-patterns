namespace DesignPatterns.Structural.Adapters
{
    public interface IMicroUsbChargeable : IChargeablePort
    {
        void ConnectedToMicroUsbCable();
        
        void DisconnectedToMicroUsbCable();
    }
}