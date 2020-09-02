using System;

namespace Figures
{
    public class Point
    {
        public double X { get; private set; }

        public double Y { get; private set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double Distance(Point point)
            => Math.Sqrt(Math.Pow(point.X - X, 2) + Math.Pow(point.Y - Y, 2));

        public override string ToString()
            => $"Point: x = {X}, y = {Y}";
    }
}