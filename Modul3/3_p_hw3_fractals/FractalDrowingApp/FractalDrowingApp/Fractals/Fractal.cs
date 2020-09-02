using System.Windows.Controls;

namespace FractalDrawingApp.Fractals
{
    public abstract class Fractal
    {
        public Canvas drawingArea;

        protected int recursionDepth;

        protected int currentDepth = 1;

        protected Fractal(Canvas drawingArea, int recursionDepth, int currentDepth)
        {
            this.drawingArea = drawingArea;
            this.recursionDepth = recursionDepth;
            this.currentDepth = currentDepth;
        }

        public abstract void Draw();
    }
}