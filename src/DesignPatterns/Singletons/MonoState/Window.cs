namespace DesignPatterns.Singletons.MonoState
{
    public class Window
    {
        private static bool _isOpen;

        public bool IsOpen
        {
            get => _isOpen;
            set => _isOpen = value;
        }
    }
}