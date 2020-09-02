using System;

namespace Structures
{
    public struct CircleS : IComparable<CircleS>
    {
        public CircleS(double xCenter, double yCenter, double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius can't be 0 or negative!");
            Center = new PointS(xCenter, yCenter);
            Radius = radius;
        }

        public PointS Center { get; private set; }

        public double Radius { get; private set; }

        public int CompareTo(CircleS another)
            => Radius > another.Radius ? 1 : Radius < another.Radius ? -1 : 0;

        public override string ToString()
            => $"Center: {Center}\nRadius = {Radius:f3}";
    }
}