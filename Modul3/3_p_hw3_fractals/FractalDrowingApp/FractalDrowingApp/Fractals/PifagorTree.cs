using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Ink;
using System.Windows.Media;
using System.Windows.Shapes;

namespace FractalDrawingApp.Fractals
{
    public class PifagorTree : Fractal
    {
        public double angle = Math.PI / 2;

        public double ang1 = Math.PI / 3;  // TODO custom angle

        public double ang2 = Math.PI / 10;  // TODO custom angle

        private double a = 200;

        private Point startPoint;

        public PifagorTree(Point startPoint, double a, double angle,
            double ang1, double ang2, Canvas drawingArea, int recursionDepth, int currentDepth) :
            base(drawingArea, recursionDepth, currentDepth)
        {
            this.ang1 = ang1;
            this.ang2 = ang2;
            this.a = a;
            this.startPoint = startPoint;
            this.angle = angle;
        }

        /// <summary>
        /// This method draws waving pifagor tree
        /// </summary>
        public override void Draw()
        {
            if (a > 2)
            {
                a *= .7; // TODO custom coefficent
                double newX = Math.Round(startPoint.X + a * Math.Cos(angle)),
                       newY = Math.Round(startPoint.Y - a * Math.Sin(angle));
                Line line = new Line()
                {
                    X1 = startPoint.X,
                    Y1 = startPoint.Y,
                    X2 = newX,
                    Y2 = newY
                };
                line.Stroke = Brushes.Red;
                drawingArea.Children.Add(line);

                PifagorTree branch1 = new PifagorTree(new Point(newX, newY), a, angle + ang1,
                    ang1, ang2, drawingArea, ++currentDepth),
                            branch2 = new PifagorTree(new Point(newX, newY), a, angle - ang2,
                    ang1, ang2, drawingArea, ++currentDepth);
                branch1.Draw();
                branch2.Draw();
            }
        }
    }
}