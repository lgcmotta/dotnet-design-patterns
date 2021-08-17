namespace DesignPatterns.Structural.Decorators
{
    public class SmsNotifierDecorator : NotifierBase
    {
        public SmsNotifierDecorator(INotifier notifier) : base(notifier)
        {
        }

        public override string Send(string message, int indent)
        {
            return $"{new string('-', indent)} Broadcasting message through SMS:\n{base.Send(message, indent + 1)}";
        }
    }
}