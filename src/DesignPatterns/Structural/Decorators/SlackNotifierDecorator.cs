namespace DesignPatterns.Structural.Decorators
{
    public class SlackNotifierDecorator : NotifierBase
    {
        public SlackNotifierDecorator(INotifier notifier) : base(notifier)
        {
        }

        public override string Send(string message, int indent)
        {
            return $"{new string('-', indent)} Broadcasting message through Slack:\n{base.Send(message, indent + 1)}";
        }
    }
}