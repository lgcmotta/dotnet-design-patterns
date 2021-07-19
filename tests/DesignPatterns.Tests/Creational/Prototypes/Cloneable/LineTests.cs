using DesignPatterns.Creational.Prototypes.Cloneable;
using FluentAssertions;
using Xunit;

namespace DesignPatterns.Tests.Creational.Prototypes.Cloneable
{
    public class LineTests
    {
        [Fact]
        public void PassingTheLineReferenceWillNotWork()
        {
            var line = new Line(new Point(0, 0), new Point(10, 10));

            var pseudoCloneLine = line;

            pseudoCloneLine.End = new Point(20, 20);
            
            pseudoCloneLine.Should().BeSameAs(line);

            Assert.Equal(line.End, pseudoCloneLine.End);
            Assert.NotEqual(10, line.End.X);
            Assert.NotEqual(10, line.End.Y);
        }

        [Fact]
        public void CloningTheLineUsingICloneableInterface()
        {
            var line = new Line(new Point(0, 0), new Point(10, 10));

            var lineClone = (Line) line.Clone();

            lineClone.Should().NotBeSameAs(line);
        }

        [Fact]
        public void CloningAndModifyingTheLineUsingICloneableInterface()
        {
            var line = new Line(new Point(0, 0), new Point(10, 10));

            var lineClone = (Line)line.Clone();

            lineClone.End = new Point(15, 20);

            lineClone.Should().NotBeSameAs(line);

            Assert.NotEqual(line.End, lineClone.End);
        }

        [Fact]
        public void CloningTheLineUsingIDeepCloneableInterface()    
        {
            var line = new Line(new Point(0, 0), new Point(10, 10));

            var lineClone = line.DeepClone();

            lineClone.Should().NotBeSameAs(line);
        }

        [Fact]
        public void CloningAndModifyingTheLineUsingIDeepCloneableInterface()
        {
            var line = new Line(new Point(0, 0), new Point(10, 10));

            var lineClone = line.DeepClone();

            lineClone.End = new Point(15, 20);

            lineClone.Should().NotBeSameAs(line);

            Assert.NotEqual(line.End, lineClone.End);
        }
    }
}   