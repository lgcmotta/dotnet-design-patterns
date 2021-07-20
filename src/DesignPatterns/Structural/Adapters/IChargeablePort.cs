using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapters
{
    public interface IChargeablePort
    {
        Task Recharge();
    }
}