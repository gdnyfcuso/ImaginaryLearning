using ImaginaryLearning.Common;
using ImaginaryLearning.Core;
using ImaginaryLearning.Core.Base;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;

namespace ImaginaryLearning
{
    class BuguaTest
    {
        [SetUp]
        public void Setup()
        {

        }

        /// <summary>
        /// 八卦圆形重叠
        /// </summary>
        [Test]
        public void CircleBuGuaTest()
        {
            Bitmap image = new Bitmap(4000, 4000);
            var o = new PointF() { X = 2000, Y = 2000 };
            var ba = new BaguaCoordinateSystem(o, 300);
            Graphics graph = Graphics.FromImage(image);
            //底色填充为白色  
            Brush white = new SolidBrush(Color.Green);
            graph.FillRectangle(white, new Rectangle(0, 0, image.Width, image.Height));

            CircleBuaGuaByPointF(graph, o, 500, 450);


            for (int i = 0; i < 8; i++)
            {
                var pointF = o.CirclePointF((8 - i) * 45, 1000);

                CircleBuaGuaByPointF(graph, pointF, 300, 250, i % 2 == 0,i%2==1);

                //graph.DrawString(ba.XianTianBaGua[i].Name, new Font("宋体", 25), Brushes.Red, o.CirclePointF((8 - i) * 45, 350));
            }

            CircleBuaGuaByPointF(graph, o, 1500, 250, false, false);
            CircleBuaGuaByPointF(graph, o, 1600, 250, false);
            CircleBuaGuaByPointF(graph, o, 1700, 250, false);
            CircleBuaGuaByPointF(graph, o, 1800, 250, false, false);

            //for (int i = 0; i < ba.HoutTianBaGuaYaoRectangleF.Count; i++)
            //{

            //    graph.FillPolygon(new SolidBrush(listColor[i % 6]), ba.HoutTianBaGuaYaoRectangleF[i].FillPolygonPointF, FillMode.Alternate);
            //}

            //for (int i = 0; i < bah.XianTianBaGuYaoRectangleF.Count; i++)
            //{

            //    graph.FillPolygon(new SolidBrush(listColor[i % 6]), bah.XianTianBaGuYaoRectangleF[i].FillPolygonPointF, FillMode.Alternate);
            //}



            image.Save("graph_CircleTest123.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
        }

        public void CircleBuaGuaByPointF(Graphics graph, PointF o, int r, int taiji = 250, bool istaiji = true, bool isXian = true)
        {
            var ba = new BaguaCoordinateSystem(o, r);
            var listColor = new List<Color>() { Color.White, Color.Black, Color.Red, Color.Yellow, Color.Blue, Color.Gold };

            if (istaiji)
            {
                TaiJi taiJi = new TaiJi();


                var r1 = new Random();
                var c1 = r1.Next(0, 100);

                taiJi.CreateTaiJiImage(o, graph, listColor[c1 % 5], listColor[c1 % 5 + 1], taiji);
            }

            if (isXian)
            {

                for (int i = 0; i < ba.XianTianBaGuYaoRectangleF.Count; i++)
                {

                    graph.FillPolygon(new SolidBrush(listColor[i % 6]), ba.XianTianBaGuYaoRectangleF[i].FillPolygonPointF, FillMode.Alternate);
                }
            }
            else
            {

                for (int i = 0; i < ba.HoutTianBaGuaYaoRectangleF.Count; i++)
                {

                    graph.FillPolygon(new SolidBrush(listColor[i % 6]), ba.HoutTianBaGuaYaoRectangleF[i].FillPolygonPointF, FillMode.Alternate);
                }
            }


        }
    }
}
