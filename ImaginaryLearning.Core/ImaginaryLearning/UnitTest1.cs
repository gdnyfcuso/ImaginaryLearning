using ImaginaryLearning.Common;
using ImaginaryLearning.Core;
using ImaginaryLearning.Core.BaGua;
using ImaginaryLearning.Core.Base;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        public void FuGuaA()
        {
            //var qian = new Qians(new PointF(), 100, 10, 30);
            //var kun=new Kuns(new PointF(),100,10,30);
            var ls = new LiuSiGuaCoordinateSystem(new PointF(), 100, 10, 30);
            ls.CreateFuGuaByCarCard();
            var listGuas = new List<int>();
            foreach (var item in FuGua.FuGuaDic.Values)
            {
                listGuas.Add(item.XuGua);
            }
            listGuas.Sort();
        } 

        [Test]
        public void XZPointTest()
        {
            Bitmap image = new Bitmap(1000, 1000);
            Graphics graph = Graphics.FromImage(image);
            Brush white = new SolidBrush(Color.White);
            graph.FillRectangle(white, new Rectangle(0, 0, image.Width, image.Height));

            var o = new PointF() { X = 500, Y = 500 };

            var one = new PointF() { X = 700, Y = 700 };

            graph.DrawEllipse(new Pen(Brushes.Red), o.X, o.Y, 20, 20);

            for (int i = 1; i <= 8; i++)
            {
                var second = o.CirclePointClockwiseRotationF(one, 45 * i);


                //graph.DrawEllipse(new Pen(Brushes.Red), one.X, one.Y, 20, 20);
                graph.DrawEllipse(new Pen(Brushes.Red), second.X, second.Y, 20, 20);
            }

            image.Save("graph_XZPointTest.bmp", System.Drawing.Imaging.ImageFormat.Bmp);

        }


        [Test]
        public void AngleRectangle()
        {
            Bitmap image = new Bitmap(1000, 1000);
            Graphics graph = Graphics.FromImage(image);
            Brush white = new SolidBrush(Color.White);
            graph.FillRectangle(white, new Rectangle(0, 0, image.Width, image.Height));

            var o = new PointF() { X = 500, Y = 500 };
            var ba = new BaguaCoordinateSystem(o, 350);
            //底色填充为白色  
            graph.FillRectangle(white, new Rectangle(0, 0, image.Width, image.Height));
            TaiJi taiJi = new TaiJi();
            taiJi.CreateTaiJiImage(o, graph, Color.Yellow, Color.Green, 180);

            var leftSPoint = new PointF(450, 250);

            var guaList = new List<DanGua>() {
            new Qian(leftSPoint),
            new Xun(leftSPoint),
            new Kan(leftSPoint),
            new Gen(leftSPoint),
            new Kun(leftSPoint),
            new Zhen(leftSPoint),
            new Li(leftSPoint),
            new Dui(leftSPoint),
            };
            for (int i = 1; i <= 8; i++)
            {
                var ang = i * 45 + 135;
                var dg = guaList[i - 1];
                foreach (var item in dg.RectangleList)
                {

                    var ps = o.RectangularRotationForCircleCentPointF(ang, item);
                    graph.DrawLine(new Pen(Brushes.Red), ps[0], ps[1]);
                    graph.DrawLine(new Pen(Brushes.Black), ps[1], ps[2]);
                    graph.DrawLine(new Pen(Brushes.Blue), ps[2], ps[3]);
                    graph.DrawLine(new Pen(Brushes.Blue), ps[3], ps[0]);
                    graph.FillPolygon(Brushes.Red, ps, FillMode.Alternate);
                }
            }

            for (int i = 0; i < 8; i++)
            {
                graph.DrawString(ba.XianTianBaGua[i].Name, new Font("宋体", 25), Brushes.Red, o.CirclePointF((8 - i) * 45, 350));
            }


            //var qian = ba.XianTianBaGua;


            //var ps = o.RectangularRotationForCircleCentPointF(45, temprec);
            //var re = ba.XianTianBaGua[0].RectangleList[0];
            //graph.DrawRectangles(new Pen(Brushes.Red), ba.XianTianBaGua[0].RectangleList.ToArray());
            //graph.DrawRectangle(new Pen(Brushes.Red), re.X, re.Y, re.Width, re.Height);

            //graph.DrawLine(new Pen(Brushes.Red), ps[0], ps[1]);
            //graph.DrawLine(new Pen(Brushes.Black), ps[1], ps[2]);
            //graph.DrawLine(new Pen(Brushes.Blue), ps[2], ps[3]);
            //graph.DrawLine(new Pen(Brushes.Blue), ps[3], ps[0]);

            //graph.DrawLines(new Pen(Brushes.Red), ps);

            graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;



            //graph.FillPolygon(Brushes.Red, ps, FillMode.Alternate);
            graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;

            image.Save("graph_ang2.bmp", System.Drawing.Imaging.ImageFormat.Bmp);

        }

        [Test]
        public void Angle()
        {
            Bitmap image = new Bitmap(1000, 1000);
            Graphics graph = Graphics.FromImage(image);
            Brush white = new SolidBrush(Color.White);
            graph.FillRectangle(white, new Rectangle(0, 0, image.Width, image.Height));

            var o = new PointF() { X = 500, Y = 500 };
            var ba = new BaguaCoordinateSystem(o, 200);
            var angle = 45;
            //底色填充为白色  
            graph.FillRectangle(white, new Rectangle(0, 0, image.Width, image.Height));

            var leftSPoint = new PointF(880, 400);

            TaiJi taiJi = new TaiJi();
            taiJi.CreateTaiJiImage(o, graph, Color.YellowGreen, Color.YellowGreen, 450);
            taiJi.CreateTaiJiImage(o, graph, Color.BlanchedAlmond, Color.BlanchedAlmond, 300);

            var temprec = new RectangleF(leftSPoint, new SizeF(30, 200));
            temprec = ba.XianTianBaGua[0].GuaRectangle;
            temprec.Location = leftSPoint;
            for (int i = 0; i < ba.XianTianBaGua.Count; i++)
            {
                //if (i == 0) continue;

                var ang = (8 - i) * angle;

                var ps = o.RectangularRotationForCircleCentPointF(ang, temprec);

                graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                graph.FillPolygon(Brushes.Red, ps, FillMode.Alternate);
                graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;

                var dg = ba.XianTianBaGua[i];

                graph.DrawString(dg.Name, new Font("宋体", 25), Brushes.Red, o.CirclePointF((8 - i) * angle, 350));
            }

            image.Save("graph_ang.bmp", System.Drawing.Imaging.ImageFormat.Bmp);

        }

        public static float AngleA(PointF cen, PointF first, PointF second)
        {
            float dx1, dx2, dy1, dy2;
            float angle;

            dx1 = first.X - cen.X;
            dy1 = first.Y - cen.Y;

            dx2 = second.X - cen.X;

            dy2 = second.Y - cen.Y;

            float c = (float)Math.Sqrt(dx1 * dx1 + dy1 * dy1) * (float)Math.Sqrt(dx2 * dx2 + dy2 * dy2);

            if (c == 0) return -1;

            angle = (float)Math.Acos((dx1 * dx2 + dy1 * dy2) / c);
            //angle * 3.14 / 180
            return (float)(angle * 180 / 3.14);
        }

        [Test]
        public void CircleTest()
        {
            Bitmap image = new Bitmap(1000, 1000);
            var o = new PointF() { X = 500, Y = 500 };
            var ba = new BaguaCoordinateSystem(o, 300);
            var angle = 45;
            Graphics graph = Graphics.FromImage(image);
            //底色填充为白色  
            Brush white = new SolidBrush(Color.Green);
            graph.FillRectangle(white, new Rectangle(0, 0, image.Width, image.Height));

            for (int i = 0; i < ba.XianTianBaGua.Count; i++)
            {
                var dg = ba.XianTianBaGua[i];
                graph.DrawString(dg.Name, new Font("宋体", 25), Brushes.Red, o.CirclePointF((8 - i) * angle, 250));
            }

            image.Save("graph_CircleTest.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
        }

        [Test]
        public void BaGuaCircle()
        {
            Bitmap image = new Bitmap(1500, 1500);
            var o = new PointF() { X = 750, Y = 750 };
            var ba = new BaguaCoordinateSystem(o, 300);
            var bah = new BaguaCoordinateSystem(o, 400);
            var angle = 45;
            Graphics graph = Graphics.FromImage(image);
            //底色填充为白色  
            Brush white = new SolidBrush(Color.Green);
            graph.FillRectangle(white, new Rectangle(0, 0, image.Width, image.Height));
            TaiJi taiJi = new TaiJi();

            taiJi.CreateTaiJiImage(o, graph, Color.Black, Color.White, 250);

            var listColor = new List<Color>() { Color.White, Color.Black, Color.Red, Color.Yellow, Color.Blue, Color.Gold };

            for (int i = 0; i < ba.HoutTianBaGuaYaoRectangleF.Count; i++)
            {
                
                graph.FillPolygon(new SolidBrush(listColor[i%6]), ba.HoutTianBaGuaYaoRectangleF[i].FillPolygonPointF, FillMode.Alternate);
            }

            for (int i = 0; i < bah.XianTianBaGuYaoRectangleF.Count; i++)
            {

                graph.FillPolygon(new SolidBrush(listColor[i % 6]), bah.XianTianBaGuYaoRectangleF[i].FillPolygonPointF, FillMode.Alternate);
            }

            

            image.Save("graph_CircleTest123.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
        }



        [Test]
        public void BaGuaTest()
        {
            var o = new PointF() { X = 500, Y = 500 };
            var ba = new BaguaCoordinateSystem(o, 300);

            TaiJi taiJi = new TaiJi();

            Bitmap image = new Bitmap(1000, 1000);

            Graphics graph = Graphics.FromImage(image);
            //底色填充为白色  
            Brush white = new SolidBrush(Color.Green);
            graph.FillRectangle(white, new Rectangle(0, 0, image.Width, image.Height));

            taiJi.CreateTaiJiImage(o, graph, Color.White, Color.Black, 250);
            var angle = 45;

            //for (int i = 0; i < ba.XianTianBaGua.Count; i++)
            //{
            //    var dg = ba.XianTianBaGua[i];
            //    graph.DrawString(dg.Name, new Font("宋体", 25), Brushes.Red, o.CirclePointF((8 - i) * angle, 200));
            //}


            List<RectangleF> rList = new List<RectangleF>();

            for (int i = 0; i < ba.XianTianBaGua.Count; i++)
            {
                var dg = ba.XianTianBaGua[i];
                rList.AddRange(dg.RectangleList);
                graph.DrawString(dg.Name, new Font("宋体", 25), Brushes.Red, o.CirclePointF((8 - i) * angle, 250));
            }


            //foreach (var item in ba.XianTianBaGua)
            //{
            //    rList.AddRange(item.RectangleList);
            //}
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
        public void BaGuaFuTest()
        {
            var listColor = new List<Color>() { Color.White, Color.Black, Color.Red, Color.Yellow, Color.Blue, Color.Gold };

            for (int i = 0; i < listColor.Count; i++)
            {
                for (int j = 0; j < listColor.Count; j++)
                {
                    for (int k = 0; k < listColor.Count; k++)
                    {
                        if (listColor[i] != listColor[j] && listColor[i] != listColor[k] && listColor[j] != listColor[k])
                        {
                            CreateTaijiBaGuaByColor(800, listColor[i], listColor[j], listColor[k], string.Format("FW{0}.jpg", i + 1), i.ToString() + j.ToString() + k.ToString());
                        }
                    }
                }
            }
        }

        [Test]
        public void BaGuaDNameTest()
        {
            CreateTaijiBaGuaByColor(1000, Color.Red, Color.Green, Color.Black, string.Empty, "N_XianTian");
            CreateTaijiBaGuaByColor(1000, Color.Red, Color.Green, Color.Black, string.Empty, "N_HouTian", false);
            CreateTaijiBaGuaByColor(1000, Color.Red, Color.Green, Color.Black, string.Empty, "S_XianTian", ISS: false);
            CreateTaijiBaGuaByColor(1000, Color.Red, Color.Green, Color.Black, string.Empty, "S_HouTian", false, ISS: false);

        }

        [Test]
        public void BaGua_img_alpha()
        {
            CreateTaijiBaGuaByColor(1000, Color.Red, Color.Green, Color.Black, string.Empty, fileName: "N_XianTian1");
            var bmp = new Bitmap("FW.png");
            var ir = new Bitmap("N_XianTian1.png");
            ir.alphaImage(bmp, 50);
            ir.Save("S_HouTian1.png");
        }

        private static void CreateTaijiBaGuaByColor(int imageWidth, Color color, Color leftColor, Color rightColor, string sFileName = "FW.png", string fileName = "graph_BaGua", bool IXH = true, bool ISS = true)
        {
            var o = new PointF() { X = imageWidth / 2, Y = imageWidth / 2 };
            var ba = new BaguaCoordinateSystem(o, imageWidth / 3, ISS);

            TaiJi taiJi = new TaiJi();

            Bitmap image = new Bitmap(imageWidth, imageWidth);

            Graphics graph = Graphics.FromImage(image);
            //底色填充为白色  
            Brush white = new SolidBrush(color);
            //graph.FillRectangle(white, new Rectangle(0, 0, image.Width, image.Height));
            if (!string.IsNullOrWhiteSpace(sFileName))
            {
                Bitmap bitmap = new Bitmap(sFileName);
                graph.DrawImage(bitmap, new RectangleF(0, 0, image.Width, image.Height));
            }


            taiJi.CreateTaiJiImage(o, graph, leftColor, rightColor, imageWidth / 12);

            var angle = 45;
            List<RectangleF> rList = new List<RectangleF>();

            var dgList = IXH ? ba.XianTianBaGua : ba.HouTianBaGua;

            for (int i = 0; i < dgList.Count; i++)
            {
                var dg = dgList[i];
                rList.AddRange(dg.RectangleList);
                graph.DrawString(dg.Name, new Font("宋体", 25), Brushes.Red, o.CirclePointF((8 - i) * angle, imageWidth / 4));
                if (IXH)
                {
                    graph.DrawString(dg.InnateNumber.ToString(), new Font("宋体", 25), Brushes.Red, o.CirclePointF((8 - i) * angle, imageWidth / 5));
                    // graph.DrawString(dg.InnateOrientation.GetDescription().ToString(), new Font("宋体", 25), Brushes.Red, o.CirclePointF((8 - i) * angle, (float)(imageWidth / 4)));
                }
                else
                {
                    graph.DrawString(dg.NumbersAcquired.ToString(), new Font("宋体", 25), Brushes.Red, o.CirclePointF((8 - i) * angle, imageWidth / 5));
                    //graph.DrawString(dg.AcquiredAzimuth.GetDescription().ToString(), new Font("宋体", 25), Brushes.Red, o.CirclePointF((8 - i) * angle, (float)(imageWidth / 4)));
                }

            }

            Pen pen = new Pen(new SolidBrush(leftColor));
            //graph.DrawEllipse(pen, 500, 500, 200, 200);//画椭圆的方法，x坐标、y坐标、宽、高，如果是100，则半径为50
            graph.DrawRectangles(pen, rList.ToArray());
            graph.FillRectangles(new SolidBrush(rightColor), rList.ToArray());
            //graph.DrawString(danGua.Name, new Font("宋体", 12), Brushes.Red, new PointF(danGua.GuaRectangle.Width + 20, danGua.GuaRectangle.Height / 2));
            //Bitmap bitmap = new Bitmap("FW.png");
            //image.alphaImage(bitmap, 100);
            //image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            image.Save(fileName + ".png", System.Drawing.Imaging.ImageFormat.Png);

            graph.Clear(Color.Azure);

            graph.Dispose();
        }

        public static Bitmap img_alpha(Bitmap src, int alpha)
        {
            Bitmap bmp = new Bitmap(src.Width, src.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            for (int h = 0; h < src.Height; h++)
                for (int w = 0; w < src.Width; w++)
                {
                    Color c = src.GetPixel(w, h);
                    bmp.SetPixel(w, h, Color.FromArgb(alpha, c.R, c.G, c.B));//色彩度最大为255，最小为0
                }
            return bmp;
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