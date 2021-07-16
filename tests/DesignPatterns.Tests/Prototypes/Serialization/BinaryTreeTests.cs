using System;
using System.Linq;
using DesignPatterns.Prototypes.Serialization;
using FluentAssertions;
using Xunit;

namespace DesignPatterns.Tests.Prototypes.Serialization
{
    public class BinaryTreeTests
    {
        private readonly Random _random;

        public BinaryTreeTests()
        {
            _random = new Random();
        }

        private int GetNumber() => _random.Next(0, 10001);

        [Fact]
        public void CopyBinaryTree_ThroughJsonSerialization()
        {
            var binaryTree = new BinaryTree();

            var numbers = new int[1000];

            for (var index = 0; index < 1000; index++)
            {
                var number = GetNumber();
                while (numbers.Any(n => n == number))
                {
                    number = GetNumber();
                }
                numbers[index] = number;
            }

            var root = numbers.Aggregate<int, Node>(null, (current, number) => binaryTree.Insert(current, number));

            var rootCopy = root.DeepCloneThroughJsonSerialization();

            rootCopy.Should()
                .NotBeSameAs(root)
                .And
                .BeEquivalentTo(root, options => options.AllowingInfiniteRecursion());
        }
    }
}