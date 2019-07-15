using ImaginaryLearning.Core;
using ImaginaryLearning.Core.BaGua;
using ImaginaryLearning.Core.Base;
using NUnit.Framework;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void BaGuaTest()
        {
            var o = new Point() { X = 500, Y =500  };
            var ba = new BaguaCoordinateSystem(o, 300);

            TaiJi taiJi = new TaiJi();

            Bitmap image = new Bitmap(1000, 1000);

            Graphics graph = Graphics.FromImage(image);
            //底色填充为白色  
            Brush white = new SolidBrush(Color.White);
            graph.FillRectangle(white, new Rectangle(0,0,image.Width,image.Height));

            taiJi.CreateTaiJiImage(o, graph, 250);


            List<RectangleF> rList = new List<RectangleF>();
            foreach (var item in ba.XianTianBaGua)
            {
                rList.AddRange(item.RectangleList);
            }
            Pen pen = new Pen(Brushes.Red);
            //graph.DrawEllipse(pen, 500, 500, 200, 200);//画椭圆的方法，x坐标、y坐标、宽、高，如果是100，则半径为50
            graph.DrawRectangles(pen, rList.ToArray());
            graph.FillRectangles(Brushes.Red, rList.ToArray());
            //graph.DrawString(danGua.Name, new Font("宋体", 12), Brushes.Red, new PointF(danGua.GuaRectangle.Width + 20, danGua.GuaRectangle.Height / 2));
            image.Save("graph_" + "BaGua" + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            graph.Clear(Color.Azure);

            graph.Dispose();
        }

        [Test]
        public void TotalTest()
        {
            DanGua_Graphics(new Qian());
            DanGua_Graphics(new Kun());
            DanGua_Graphics(new Zhen());
            DanGua_Graphics(new Dui());
            DanGua_Graphics(new Kan());
            DanGua_Graphics(new Li());
            DanGua_Graphics(new Gen());
            DanGua_Graphics(new Xun());
        }

        [Test]
        public void totalTestList()
        {
            var guaList = new List<DanGua>() {
            new Qian(),
            new Kun(),
            new Zhen(),
            new Dui(),
            new Kan(),
            new Li(),
            new Gen(),
            new Xun(),};

            foreach (var item in guaList)
            {
                item.SaveGuaImage();
            }
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

            List<RectangleF> list = new List<RectangleF>();
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
            graph.DrawString(kun.Name, new Font("宋体", 12), Brushes.Red, new PointF(0, 45));
            image.Save("graph_Kun.bmp", System.Drawing.Imaging.ImageFormat.Bmp);

        }

        [Test]
        public void DanGua_KAN_Test()
        {
            var startPoint = new Point(0, 0);

            var kun = new Kan(startPoint, 200, 15, 20);

            Image image = new Bitmap(800, 800);

            Graphics graph = Graphics.FromImage(image);

            graph.Clear(Color.Azure);
            Pen pen = new Pen(Brushes.Red);
            graph.DrawRectangles(pen, kun.RectangleList.ToArray());
            graph.FillRectangles(Brushes.Red, kun.RectangleList.ToArray());
            graph.DrawString(kun.Name, new Font("宋体", 12), Brushes.Red, new PointF(startPoint.X + 220, startPoint.Y + 100));
            image.Save("graph_Kan.bmp", System.Drawing.Imaging.ImageFormat.Bmp);

        }

        public void DanGua_Graphics(DanGua danGua)
        {

            Image image = new Bitmap(400, 400);

            Graphics graph = Graphics.FromImage(image);

            graph.Clear(Color.Azure);
            Pen pen = new Pen(Brushes.Red);
            graph.DrawRectangles(pen, danGua.RectangleList.ToArray());
            graph.FillRectangles(Brushes.Red, danGua.RectangleList.ToArray());
            graph.DrawString(danGua.Name, new Font("宋体", 12), Brushes.Red, new PointF(danGua.GuaRectangle.Width + 20, danGua.GuaRectangle.Height / 2));
            image.Save("graph_" + danGua.Name + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);

        }



        [Test]
        public void DanGua_li_Test()
        {
            var startPoint = new Point(0, 0);

            var kun = new Li(startPoint, 200, 15, 20);

            Image image = new Bitmap(800, 800);

            Graphics graph = Graphics.FromImage(image);

            graph.Clear(Color.Azure);
            Pen pen = new Pen(Brushes.Red);
            graph.DrawRectangles(pen, kun.RectangleList.ToArray());
            graph.FillRectangles(Brushes.Red, kun.RectangleList.ToArray());
            graph.DrawString(kun.Name, new Font("宋体", 12), Brushes.Red, new PointF(startPoint.X + 220, startPoint.Y + 100));
            image.Save("graph_LI.bmp", System.Drawing.Imaging.ImageFormat.Bmp);

        }

        [Test]
        public void TaiJi()
        {
            var taiji = new TaiJi();
            taiji.CreateTaiJiImage();
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
            graph.DrawString(pI.Name, new Font("宋体", 12), Brushes.Red, new PointF(startPoint.X + 220, startPoint.Y + 100));
            image.Save("graph_PI.bmp", System.Drawing.Imaging.ImageFormat.Bmp);

        }
    }
}