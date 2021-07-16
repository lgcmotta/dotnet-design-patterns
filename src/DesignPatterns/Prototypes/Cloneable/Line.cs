using System;

namespace DesignPatterns.Prototypes.Cloneable
{
    public class Line : ICloneable, IDeepCloneable<Line>
    {
        public Point Start { get; set; }

        public Point End { get; set; }

        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
        }

        public object Clone()
        {
            return new Line((Point) Start.Clone(), (Point) End.Clone());
        }

        public Line DeepClone()
        {
            return new(Start.DeepClone(), End.DeepClone());
        }
    }

    public class Point : ICloneable, IDeepCloneable<Point>
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public object Clone()
        {
            return new Point(X, Y);
        }

        public Point DeepClone()
        {
            return new (X, Y);
        }
    }
}