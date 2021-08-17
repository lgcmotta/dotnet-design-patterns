namespace DesignPatterns.Structural.Decorators
{
    public class FacebookNotifierDecorator : NotifierBase
    {
        public FacebookNotifierDecorator(INotifier notifier) : base(notifier)
        {
        }

        public override string Send(string message, int indent)
        {
            return $"{new string('-', indent)} Broadcasting message through Facebook:\n{base.Send(message, indent + 1)}";
        }
    }
}