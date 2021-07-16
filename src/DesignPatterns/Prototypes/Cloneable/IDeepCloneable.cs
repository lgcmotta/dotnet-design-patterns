namespace DesignPatterns.Prototypes.Cloneable
{
    public interface IDeepCloneable<out TObject>
    {
        TObject DeepClone();
    }
}