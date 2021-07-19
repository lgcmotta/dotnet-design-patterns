using System;

namespace DesignPatterns.Creational.Prototypes.Cloneable
{
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