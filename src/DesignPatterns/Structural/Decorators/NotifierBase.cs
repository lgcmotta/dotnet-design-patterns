namespace DesignPatterns.Structural.Decorators
{
    public abstract class NotifierBase : INotifier
    {
        private readonly INotifier _notifier;

        protected NotifierBase(INotifier notifier)
        {
            _notifier = notifier;
        }

        public virtual string Send(string message, int indent) => _notifier.Send(message, indent);
    }
}