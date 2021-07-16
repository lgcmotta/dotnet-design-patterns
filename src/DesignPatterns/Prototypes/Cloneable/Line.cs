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
}