namespace DesignPatterns.Structural.Decorators
{
    public interface INotifier
    {
        string Send(string message, int indent);
    }
}