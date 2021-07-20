namespace DesignPatterns.Structural.Adapters
{
    public interface ILightningChargeable : IChargeablePort
    {
        void ConnectedToLightningCable();

        void DisconnectedToLightingCable();
    }
}