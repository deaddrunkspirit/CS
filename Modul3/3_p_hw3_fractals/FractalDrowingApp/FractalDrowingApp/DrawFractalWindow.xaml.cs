using FractalDrawingApp.Fractals;
using System.Drawing;
using System.Windows;
using System.Windows.Media;

namespace FractalDrawingApp
{
    public partial class DrawFractalWindow : Window
    {
        //private Fractal fractal;

        public DrawFractalWindow(char fractalType)
        {
            //    InitializeComponent();
            //    switch (fractalType)
            //    {
            //        case '1':
            //            fractal = new PifagorTree(drawingArea, recursionLabel);
            //            break;

            //        case '2':
            //            fractal = new PifagorTree(canvas1, recursionLabel);
            //            break;

            //        case '3':
            //            fractal = new PifagorTree(canvas1, recursionLabel);
            //            break;

            //        case '4':
            //            fractal = new PifagorTree(canvas1, recursionLabel);
            //            break;
            //    }
        }

        //private void Form1_Load(object sender, RoutedEventArgs e)
        //{
        //    map = new Bitmap(pictureBox1.Width, pictureBox1.Height);//Подключаем Битмап
        //    g = Graphics.FromImage(map); //Подключаем графику
        //    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;//Включаем сглаживание
        //    p = new Pen(Color.Green);   //Зеленая ручка

        //    //Вызов рекурсивной функции отрисовки дерева
        //    Draw(300, 450, 200, angle);

        //    //Переносим картинку из битмапа на picturebox
        //    pictureBox1.BackgroundImage = map;
        //}

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            //    fractal.canvas.Children.Clear();
            //    recursionLabel.Text = "";
            //    fractal.i = 0;
            //    fractal.currentRecursionDepth = 1;
            //    CompositionTarget.Rendering += fractal.StartAnimation;
        }
    }
}