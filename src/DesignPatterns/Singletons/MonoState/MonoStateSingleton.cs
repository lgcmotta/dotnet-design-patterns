namespace DesignPatterns.Singletons.MonoState
{
    public class MonoStateSingleton
    {
        private static bool _state;

        public bool State
        {
            get => _state;
            set => _state = value;
        }
    }
}