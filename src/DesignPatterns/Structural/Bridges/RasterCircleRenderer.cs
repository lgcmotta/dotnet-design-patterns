namespace DesignPatterns.Structural.Bridges
{
    public class RasterCircleRenderer : IRenderer
    {
        public string RenderCircle(float radius) => $"Drawing a circle of radius {radius} in pixels";
    }
}