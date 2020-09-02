using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace FractalDrawingApp.Fractals
{
    public class SerpinskyTriangle : Fractal
    {
        /// <summary>
        /// These are middle points for each iteration
        /// </summary>
        private Point top, right, left;

        /// <summary>
        /// This constructor creates an instance of Serpinsky triangle
        /// </summary>
        /// <param name="top">top point of the triangle</param>
        /// <param name="right">right point</param>
        /// <param name="left">left point of the triangle</param>
        /// <param name="drawingArea">area where to draw</param>
        /// <param name="recursionDepth">all iterations count</param>
        /// <param name="currentDepth">current iteration number</param>
        public SerpinskyTriangle(Point top, Point right, Point left,
            Canvas drawingArea, int recursionDepth, int currentDepth)
            : base(drawingArea, recursionDepth, currentDepth)
        {
            this.top = top;
            this.right = right;
            this.left = left;
        }

        /// <summary>
        /// This method draws Serpinsky triangle in specified Canvas module
        /// </summary>
        public override void Draw()
        {
            if (recursionDepth == currentDepth)
            {
                PointCollection points = new PointCollection
                {
                    top, right, left, top
                };

                var polyLine = new Polyline();
                polyLine.Points = points;
                polyLine.Stroke = Brushes.Red;
                drawingArea.Children.Add(polyLine);
            }
            else
            {
                Point leftMid = MidPoint(top, left);
                Point rightMid = MidPoint(top, right);
                Point topMid = MidPoint(left, right);
                SerpinskyTriangle triangle1 = new SerpinskyTriangle(top, leftMid, rightMid,
                    drawingArea, recursionDepth, currentDepth + 1),
                                  triangle2 = new SerpinskyTriangle(leftMid, left, topMid,
                    drawingArea, recursionDepth, currentDepth + 1),
                                  triangle3 = new SerpinskyTriangle(rightMid, topMid, right,
                    drawingArea, recursionDepth, currentDepth + 1);
                triangle1.Draw();
                triangle2.Draw();
                triangle3.Draw();
            }
        }

        /// <summary>
        /// This method calculates middle point between two points
        /// </summary>
        /// <param name="point1">first point</param>
        /// <param name="point2">second point</param>
        /// <returns></returns>
        private static Point MidPoint(Point point1, Point point2)
            => new Point((point1.X + point2.X) / 2, (point1.Y + point2.Y) / 2);
    }
}