using DesignPatterns.Structural.Composites;
using Xunit;

namespace DesignPatterns.Tests.Structural.Composites
{
    public class CompositeTests
    {
        [Fact]
        public void CreateCompositeThree()
        {
            var three = new Composite { new Leaf() };
            
            var firstBranch = new Composite { new Leaf(), new Leaf() };
            
            var secondBranch = new Composite();

            var thirdBranch = new Composite { new Leaf() };

            secondBranch.Add(thirdBranch);

            three.Add(firstBranch);
            
            three.Add(secondBranch);

            var operation = three.Operation();

            Assert.Equal("Composite(Leaf+Composite(Leaf+Leaf)+Composite(Composite(Leaf)))", operation);
        }
    }
}