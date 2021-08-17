namespace DesignPatterns.Structural.Decorators
{
    public class Notifier : INotifier
    {
        public string Send(string message, int indent)
        {
            return $"{new string('-', indent)} Broadcasting message: {message}";
        }
    }
}