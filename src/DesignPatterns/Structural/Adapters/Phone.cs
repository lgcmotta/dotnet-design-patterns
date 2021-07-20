namespace DesignPatterns.Structural.Adapters
{
    public class Phone
    {
        protected bool CableConnected;

        public bool Recharged { get; protected set; } = false;
    }
}