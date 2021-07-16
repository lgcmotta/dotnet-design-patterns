using System;

namespace DesignPatterns.Factories.Inner
{
    public class Point
    {
        public double X { get; }

        public double Y { get; }

        public static Factory PointFactory => new();

        private Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"{nameof(X)}: {X}, {nameof(Y)}: {Y}";
        }

        public class Factory
        {
            public static Point NewCartesianPoint(double x, double y) => new(x, y);

            public static Point NewPolarPoint(double rho, double theta) =>
                new(rho * Math.Cos(theta), rho * Math.Sin(theta));

            internal Factory() { }
        }

    }
}