namespace DesignPatterns.Creational.Prototypes.Cloneable
{
    public interface IDeepCloneable<out TObject>
    {
        TObject DeepClone();
    }
}