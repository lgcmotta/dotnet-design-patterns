using DesignPatterns.Structural.Bridges;
using Xunit;

namespace DesignPatterns.Tests.Structural.Bridges
{
    public class CircleRenderTests
    {
        [Fact]
        public void RenderACircleUsingVectorRenderer()
        {
            var circle = new Circle(5, new VectorCircleRenderer());

            var drawnCircle1 = circle.Draw();
            
            circle.Resize(2);

            var drawnCircle2 = circle.Draw();
            
            Assert.Equal("Drawing a circle of radius 5 in vector form", drawnCircle1);
            
            Assert.Equal("Drawing a circle of radius 10 in vector form", drawnCircle2);
        }

        [Fact]
        public void RenderACircleUsingRasterRenderer()
        {
            var circle = new Circle(5, new RasterCircleRenderer());

            var drawnCircle1 = circle.Draw();

            circle.Resize(2);

            var drawnCircle2 = circle.Draw();

            Assert.Equal("Drawing a circle of radius 5 in pixels", drawnCircle1);

            Assert.Equal("Drawing a circle of radius 10 in pixels", drawnCircle2);
        }
    }
}