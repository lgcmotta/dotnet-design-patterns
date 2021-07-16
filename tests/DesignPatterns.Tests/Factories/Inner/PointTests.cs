using System;
using DesignPatterns.Factories.Inner;
using FluentAssertions;
using Xunit;

namespace DesignPatterns.Tests.Factories.Inner
{
    public class PointTests
    {
        [Fact]
        public void CreateCartesianPoint_Success()
        {
            var point = Point.Factory.NewCartesianPoint(0, 0);

            point.Should().NotBeNull();
        }

        [Fact]
        public void CreatePolarPoint_Success()
        {
            var point = Point.Factory.NewPolarPoint(1, Math.PI / 2);

            point.Should().NotBeNull();
        }
    }
}