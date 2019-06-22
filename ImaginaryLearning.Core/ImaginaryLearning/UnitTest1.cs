using ImaginaryLearning.Core;
using NUnit.Framework;
using System.Drawing;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var yinYao = new YinYao(new Point() { X = 0, Y = 0 }, 100, 10, 10);
            int x = 100;
            Image image = new Bitmap(100, 100);

            Graphics graph = Graphics.FromImage(image);

            graph.Clear(Color.Azure);
            Pen pen = new Pen(Brushes.Red);
            graph.DrawRectangles(pen, yinYao.RectangleList.ToArray());
            graph.FillRectangles(Brushes.Red, yinYao.RectangleList.ToArray());
            image.Save("graph.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
        }
    }
}