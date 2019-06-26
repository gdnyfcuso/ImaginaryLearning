using ImaginaryLearning.Core;
using ImaginaryLearning.Core.BaGua;
using NUnit.Framework;
using System.Collections.Generic;
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
        public void YinYaoTest()
        {
            var yinYao1 = new YinYao(new Point() { X = 0, Y = 0 }, 100, 10, 10);

            var yinYao2 = new YinYao(new Point() { X = 0, Y = 20 }, 100, 10, 10);

            var yinYao3 = new YinYao(new Point() { X = 0, Y = 40 }, 100, 10, 10);

            int x = 100;
            Image image = new Bitmap(100, 100);

            Graphics graph = Graphics.FromImage(image);

            List<Rectangle> list = new List<Rectangle>();
            list.AddRange(yinYao1.RectangleList);
            list.AddRange(yinYao2.RectangleList);
            list.AddRange(yinYao3.RectangleList);
            graph.Clear(Color.Azure);
            Pen pen = new Pen(Brushes.Red);
            graph.DrawRectangles(pen, list.ToArray());
            graph.FillRectangles(Brushes.Red, list.ToArray());
            image.Save("graph.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
        }

        [Test]
        public void DanGuaTest()
        {
            var kun = new Kun();

            int x = 100;
            Image image = new Bitmap(100, 100);

            Graphics graph = Graphics.FromImage(image);

            graph.Clear(Color.Azure);
            Pen pen = new Pen(Brushes.Red);
            graph.DrawRectangles(pen, kun.RectangleList.ToArray());
            graph.FillRectangles(Brushes.Red, kun.RectangleList.ToArray());
            graph.DrawString(kun.Name, new Font("ËÎÌו", 12), Brushes.Red, new PointF(0, 45));
            image.Save("graph_Kun.bmp", System.Drawing.Imaging.ImageFormat.Bmp);

        }

        [Test]
        public void FuGua_PI_Test()
        {
            var startPoint = new Point(0, 0);

            var pI = new PI(startPoint, 200, 15, 20);

            int x = 100;
            Image image = new Bitmap(800, 800);

            Graphics graph = Graphics.FromImage(image);

            graph.Clear(Color.Azure);
            Pen pen = new Pen(Brushes.Red);
            graph.DrawRectangles(pen, pI.RectangleList.ToArray());
            graph.FillRectangles(Brushes.Red, pI.RectangleList.ToArray());
            graph.DrawString(pI.Name, new Font("ËÎÌו", 12), Brushes.Red, new PointF(startPoint.X + 220, startPoint.Y + 100));
            image.Save("graph_PI.bmp", System.Drawing.Imaging.ImageFormat.Bmp);

        }
    }
}