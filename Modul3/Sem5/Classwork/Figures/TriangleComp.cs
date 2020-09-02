using System;

namespace Figures
{
    public class TriangleComp
    {
        public Point[] _points = new Point[3];

        public double[] _sides = new double[3];

        /// <summary>
        /// This constructor gets all x and y of triangle points,
        /// then checks triangle inequality
        /// </summary>
        /// <param name="xParametrs">array of x parametrs</param>
        /// <param name="yParametrs">array of y parametrs</param>
        public TriangleComp(double[] xParametrs, double[] yParametrs)
        {
            for (int i = 0; i < 3; i++)
                _points[i] = new Point(xParametrs[i], yParametrs[i]);
            _sides[0] = _points[0].Distance(_points[1]);
            _sides[1] = _points[1].Distance(_points[2]);
            _sides[2] = _points[0].Distance(_points[2]);
            if (_sides[1] >= _sides[2] + _sides[0] || _sides[2] >= _sides[1] + _sides[0] ||
                _sides[0] >= _sides[1] + _sides[2])
                throw new ArgumentException("Triangle inequality isn't satisfied");
        }

        /// <summary>
        /// This property returns triangle square using Geron formula
        /// </summary>
        public double Square
        {
            get
            {
                double p = 0.5 * (_sides[0] + _sides[1] + _sides[2]);
                return p * (p - _sides[0]) * (p - _sides[1]) * (p - _sides[2]);
            }
        }

        /// <summary>
        /// This method checks if point P belongs to triangle using vectors.
        /// We put point A to (0, 0), then transfer points B, C and P relative to A,
        /// then check if given point is betveen vectors AB and AC
        /// </summary>
        /// <param name="point">Point to check</param>
        /// <returns></returns>
        public bool PointBelongsToTriangle(Point point)
        {
            bool result = false;
            Point B = new Point(_points[1].X - _points[0].X, _points[1].Y - _points[0].Y),
                C = new Point(_points[2].X - _points[0].X, _points[2].Y - _points[0].Y),
                P = new Point(point.X - _points[0].X, point.Y - _points[0].Y);
            double m = (P.X * B.Y - B.X * P.Y) / (C.X * B.Y - B.X * C.Y);
            if (m >= 0 && m <= 1)
            {
                double l = (P.X - m * C.X) / B.X;
                if (l >= 0 && (m + l) <= 1)
                    result = true;
            }

            return result;
        }

        public override string ToString()
            => $"Triangle\n{_points[0]}\n{_points[1]}\n{_points[2]}";
    }
}