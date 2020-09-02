using FractalDrawingApp.Fractals;
using System;
using System.Windows;

namespace FractalDrawingApp
{
    public partial class DrawingWindow : Window
    {
        private Fractal fractal;

        public DrawingWindow(int type)
        {
            InitializeComponent();

            //fractal = new PifagorTree(new Point(drawingArea.Width / 2, drawingArea.Height),
            //    200, Math.PI / 2, Math.PI / 4, Math.PI / 6, drawingArea, 4);
            fractal = new SerpinskyTriangle(new Point(0, drawingArea.Height),
                new Point(drawingArea.Width, drawingArea.Height),
                new Point(drawingArea.Width / 2, drawingArea.Height - drawingArea.Width * Math.Sqrt(3) / 2),
                drawingArea, 10, 0);
            fractal.Draw();
        }
    }
}