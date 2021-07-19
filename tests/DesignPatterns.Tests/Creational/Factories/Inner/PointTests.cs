using System;
using DesignPatterns.Creational.Factories.Inner;
using FluentAssertions;
using Xunit;

namespace DesignPatterns.Tests.Creational.Factories.Inner
{
    public class PointTests
    {
        [Fact]
        public void CreateCartesianPoint()
        {
            var point = Point.Factory.NewCartesianPoint(0, 0);

            point.Should().NotBeNull();
        }

        [Fact]
        public void CreatePolarPoint()
        {
            var point = Point.Factory.NewPolarPoint(1, Math.PI / 2);

            point.Should().NotBeNull();
        }
    }
}