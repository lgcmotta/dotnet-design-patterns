namespace DesignPatterns.Structural.Bridges
{
    public class VectorCircleRenderer : IRenderer
    {
        public string RenderCircle(float radius) => $"Drawing a circle of radius {radius} in vector form";
    }
}