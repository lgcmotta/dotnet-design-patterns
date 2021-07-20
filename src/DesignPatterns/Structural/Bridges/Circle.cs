namespace DesignPatterns.Structural.Bridges
{
    public class Circle : Shape
    {
        private float _radius;

        public Circle(float radius, IRenderer renderer) : base(renderer)
        {
            _radius = radius;
        }

        public override string Draw()
        {
            return Renderer.RenderCircle(_radius);
        }

        public override void Resize(float factor)
        {
            _radius *= factor;
        }
    }
}