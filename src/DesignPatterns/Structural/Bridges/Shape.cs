namespace DesignPatterns.Structural.Bridges
{
    public abstract class Shape
    {
        protected IRenderer Renderer;

        protected Shape(IRenderer renderer)
        {
            Renderer = renderer;
        }

        public abstract string Draw();

        public abstract void Resize(float factor);
    }
}