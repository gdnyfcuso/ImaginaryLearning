using ImaginaryLearning.Common;
using ImaginaryLearning.Core;
using ImaginaryLearning.Core.BaGua;
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

        [Test]
        public void BaGua()
        {
            var pointf = new PointF(500, 500);
            var ba = new BaguaCoordinateSystem(pointf, 300);
            ba.CreateBaGuaImage("CreateBaGuaImage.png");
        }

        [Test]
        public void baGuaWord()
        {
            Bitmap image = new Bitmap(1000, 1000);
            var o = new PointF() { X = 500, Y = 500 };
            Graphics graph = Graphics.FromImage(image);
            Brush white = new SolidBrush(Color.Green);
            graph.FillRectangle(white, new Rectangle(0, 0, image.Width, image.Height));
            CircleBuaGuaByPointF(graph, o, 300, 200, true);
            DrawGuaString(o, graph, 380,fontSize:50);
            image.Save("Bagua.bmp");

        }

        [Test]
        public void MatrixTest()
        {
            Bitmap image = new Bitmap(1000, 1000);
            var o = new PointF() { X = 500, Y = 500 };
            var ba = new BaguaCoordinateSystem(o, 300);
            Graphics graph = Graphics.FromImage(image);
            var leftSPoint = o;

            var guaList = new List<DanGua>() {
            new Xun(leftSPoint),
            new Kan(leftSPoint),
            new Gen(leftSPoint),
            new Kun(leftSPoint),
            new Zhen(leftSPoint),
            new Li(leftSPoint),
            new Dui(leftSPoint),
            new Qian(leftSPoint),
            };



            for (int i = 0; i < 8; i++)
            {
                Matrix matrix = graph.Transform;


                Font font = new Font("宋体", 100, GraphicsUnit.Pixel);
                var pointF = new PointF(500, 500).CirclePointF(90, 200);
                SizeF sf = graph.MeasureString(guaList[i].Name, font); // 计算出来文字所占矩形区域
                                                                       //matrix.RotateAt(45, pointF);
                graph.FillEllipse(Brushes.Red, new RectangleF(new PointF(0, 0), new SizeF() { Width = 10, Height = 10 }));
                graph.FillEllipse(Brushes.Blue, new RectangleF(o, new SizeF(10, 10)));
                matrix.RotateAt(45, new PointF() { X = 500, Y = 500 });
                graph.Transform = matrix;
                var rf = new RectangleF(500 - sf.Width / 2, 100 - sf.Height / 2, sf.Width, sf.Height);
                graph.FillRectangle(Brushes.Gray, rf);
                graph.DrawLine(Pens.Red, 500, 500, 500, 100);
                graph.DrawString(guaList[i].Name, font, Brushes.Red, new RectangleF(500 - sf.Width / 2, 100 - sf.Height / 2, sf.Width, sf.Height));
            }



            //graph.TranslateTransform(500, 500);



            image.Save("mat.bmp");


        }

        public void DrawGuaString(PointF o, Graphics graph, int r, string fontName="宋体", int fontSize=25,int angle=45)
        {
            var guaList = new List<DanGua>() {
            new Xun(o),
            new Kan(o),
            new Gen(o),
            new Kun(o),
            new Zhen(o),
            new Li(o),
            new Dui(o),
            new Qian(o),
            };

            for (int i = 0; i < 8; i++)
            {
                Matrix matrix = graph.Transform;
                Font font = new Font(fontName, fontSize, GraphicsUnit.Pixel);
                SizeF sf = graph.MeasureString(guaList[i].Name, font); // 计算出来文字所占矩形区域
                matrix.RotateAt(angle, o);
                graph.Transform = matrix;
                var rf = new RectangleF(o.X - sf.Width / 2, o.Y-r - sf.Height / 2, sf.Width, sf.Height);
                graph.DrawString(guaList[i].Name, font, Brushes.Black, rf);
            }

        }





        [Test]
        public void WordBuguaTest()
        {
            Bitmap image = new Bitmap(1000, 1000);
            var o = new PointF() { X = 500, Y = 500 };
            var ba = new BaguaCoordinateSystem(o, 300);
            Graphics graph = Graphics.FromImage(image);
            //底色填充为白色  
            Brush white = new SolidBrush(Color.Green);
            graph.FillRectangle(white, new Rectangle(0, 0, image.Width, image.Height));

            //CircleBuaGuaByPointF(graph, o, 500, 450);



            //SizeF sf = graph.MeasureString("中国", font); // 计算出来文字所占矩形区域

            //var aa = o.CirclePointF(225, 350);
            //matrix.RotateAt(45+90+180, new PointF(aa.X + sf.Width / 2, aa.Y + sf.Height / 2));
            //graph.Transform = matrix;

            //graph.DrawString("中国", font, new SolidBrush(Color.Black), aa);


            var pointF = o.CirclePointF(0, 350);
            SizeF sf = graph.MeasureString(ba.XianTianBaGua[0].Name, new Font("宋体", 25)); // 计算出来文字所占矩形区域
            var rf = new RectangleF(o.CirclePointF(0, 350), sf);
            Matrix matrix = graph.Transform;

            //matrix.RotateAt(0, new PointF(pointF.X + sf.Width / 2, pointF.Y + sf.Height / 2));
            //////matrix.RotateAt(i * 45, );
            //graph.Transform = matrix;

            //graph.FillRectangle(Brushes.Blue, rf);
            //graph.DrawString(ba.XianTianBaGua[0].Name, new Font("宋体", 25), Brushes.Red, rf);


            //pointF = o.CirclePointF(45, 350);
            //sf = graph.MeasureString(ba.XianTianBaGua[8 - 1].Name, new Font("宋体", 25)); // 计算出来文字所占矩形区域
            //rf = new RectangleF(o.CirclePointF(45, 350), sf);
            //matrix = graph.Transform;

            //matrix.RotateAt(90 + 45, new PointF(pointF.X + sf.Width / 2, pointF.Y + sf.Height / 2));
            //////matrix.RotateAt(i * 45, );
            //graph.Transform = matrix;

            //graph.FillRectangle(Brushes.Blue, rf);
            //graph.DrawString(ba.XianTianBaGua[8 - 1].Name, new Font("宋体", 25), Brushes.Red, rf);

            //pointF = o.CirclePointF(135, 350);
            //sf = graph.MeasureString(ba.XianTianBaGua[8 - 2].Name, new Font("宋体", 25)); // 计算出来文字所占矩形区域
            //rf = new RectangleF(o.CirclePointF(60, 350), sf);
            matrix = graph.Transform;

            matrix.RotateAt(45 * 2, new PointF(pointF.X + sf.Width / 2, pointF.Y + sf.Height / 2));
            ////matrix.RotateAt(i * 45, );
            graph.Transform = matrix;

            graph.FillRectangle(Brushes.Blue, rf);
            graph.DrawString(ba.XianTianBaGua[0].Name, new Font("宋体", 25), Brushes.Red, rf);


            //pointF = o.CirclePointF(, 350);
            //var pointF = o.CirclePointF(45, 100);
            //AddText(graph, pointF, 25, ba.XianTianBaGua[8 - 3].Name, 20);

            // pointF = o.CirclePointF(90, 100);
            //AddText(graph, pointF, 25, ba.XianTianBaGua[8 - 5].Name, 20);

            // pointF = o.CirclePointF(120, 100);
            //AddText(graph, pointF, 25, ba.XianTianBaGua[8 - 6].Name, 20);




            //var pointF = o.CirclePointF((8 - 2) * 45, 300);
            var leftSPoint = pointF;
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

            //for (int i = 0; i < 2; i++)
            //{
            //    Matrix matrix = graph.Transform;
            //    AddText(graph, pointF, 25, guaList[i].Name, matrix, i * 45);
            //    graph.Transform = matrix;

            //}

            //for (int i = 1; i <= 8; i++)
            //{
            //    //var pointF = o.CirclePointF((8 - i) * 45, 1000);
            //    //Font font = new Font("宋体", 25);
            //    SizeF sf = graph.MeasureString(ba.XianTianBaGua[i-1].Name, new Font("宋体", 25)); // 计算出来文字所占矩形区域

            //    var aa = o.CirclePointF(i*45f, 350);
            //    Matrix matrix = graph.Transform;

            //    //matrix.RotateAt(i*45+135, new PointF(aa.X + sf.Width / 2, aa.Y + sf.Height / 2));
            //    matrix.RotateAt(i*45, aa);

            //    graph.Transform = matrix;

            //    //CircleBuaGuaByPointF(graph, pointF, 300, 250, i % 2 == 0, i % 2 == 1);
            //    var rf = new RectangleF(aa, new SizeF(40, 40));
            //    graph.FillRectangle(Brushes.Blue, rf);
            //    var ss = new StringFormat();
            //    graph.DrawString(ba.XianTianBaGua[i-1].Name, new Font("宋体", 25), Brushes.Red, rf, ss);
            //}

            image.Save("graph_CircleTest123456.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
        }

        [Test]
        public void WordMatrix()
        {
            WordMatrix(0, "0");
            WordMatrix((RotateFlipType)1, "1");
            WordMatrix((RotateFlipType)2, "2");
            WordMatrix((RotateFlipType)3, "3");
            WordMatrix((RotateFlipType)4, "4");
            WordMatrix((RotateFlipType)5, "5");
            WordMatrix((RotateFlipType)6, "6");
            WordMatrix((RotateFlipType)7, "7");
            var img0 = Image.FromFile("2.bmp");
            var img1 = Image.FromFile("4.bmp");
            var img2 = Image.FromFile("3.bmp");
            var img3 = Image.FromFile("0.bmp");

            Bitmap image = new Bitmap(2000, 2000);
            var o = new PointF() { X = 500, Y = 500 };
            var ba = new BaguaCoordinateSystem(o, 300);
            Graphics graph = Graphics.FromImage(image);
            Brush white = new SolidBrush(Color.Green);
            graph.FillRectangle(white, new Rectangle(0, 0, image.Width, image.Height));
            graph.DrawImage(img0, new Point(0, 0));
            graph.DrawImage(img1, new Point(0, 1000));
            graph.DrawImage(img2, new Point(1000, 0));
            graph.DrawImage(img3, new Point(1000, 1000));

            image.Save("ok.bmp");



        }

        public void WordMatrix(RotateFlipType rotateFlipType, string fileName)
        {
            Bitmap image = new Bitmap(1000, 1000);
            var o = new PointF() { X = 500, Y = 500 };
            var ba = new BaguaCoordinateSystem(o, 300);
            Graphics graph = Graphics.FromImage(image);
            //底色填充为白色  
            Brush white = new SolidBrush(Color.White);
            graph.FillRectangle(white, new Rectangle(0, 0, image.Width, image.Height));

            for (int i = 0; i <= 90; i += 10)
            {
                Font font = new Font("宋体", 50, GraphicsUnit.Pixel);
                var pointF = new PointF(0, 0).CirclePointF(i, 200);
                Matrix matrix = graph.Transform;
                SizeF sf = graph.MeasureString("中", font); // 计算出来文字所占矩形区域
                matrix.RotateAt(i, new PointF(pointF.X + sf.Width / 2, pointF.Y + sf.Height / 2));

                //matrix.Rotate(i);
                graph.DrawLine(Pens.Black, 0, 0, 800, 0);
                graph.DrawString("中", font, Brushes.Red, new RectangleF(800, 0, sf.Width, sf.Height));
                //graph.TranslateTransform(500, 500);

                graph.Transform = matrix;

            }
            image.RotateFlip(rotateFlipType);
            image.Save(fileName + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
        }



        /// <summary>
        /// 图片添加任意角度文字(文字旋转是中心旋转，角度顺时针为正)
        /// </summary>
        /// <param name="imgPath">图片路径</param>
        /// <param name="locationLeftTop">文字左上角定位(x1,y1)</param>
        /// <param name="fontSize">字体大小，单位为像素</param>
        /// <param name="text">文字内容</param>
        /// <param name="angle">文字旋转角度</param>
        /// <param name="fontName">字体名称</param>
        /// <returns>添加文字后的Bitmap对象</returns>
        public void AddText(Graphics graphics, PointF locationLeftTop, int fontSize, string text, Matrix matrix, int angle = 0, string fontName = "华文行楷")
        {
            //Image img = Image.FromFile(imgPath);

            //int width = img.Width;
            //int height = img.Height;
            //Bitmap bmp = new Bitmap(width, height);
            //Graphics graphics = Graphics.FromImage(bmp);
            // 画底图
            //graphics.DrawImage(img, 0, 0, width, height);

            Font font = new Font(fontName, fontSize, GraphicsUnit.Pixel);
            SizeF sf = graphics.MeasureString(text, font); // 计算出来文字所占矩形区域
            // 左上角定位
            //string[] location = locationLeftTop.Split(',');
            float x1 = locationLeftTop.X;
            float y1 = locationLeftTop.Y;

            // 进行文字旋转的角度定位
            if (angle != 0)
            {
                #region 法一：TranslateTransform平移 + RotateTransform旋转

                /* 
                    * 注意：
                    * Graphics.RotateTransform的旋转是以Graphics对象的左上角为原点，旋转整个画板的。
                    * 同时x，y坐标轴也会跟着旋转。即旋转后的x，y轴依然与矩形的边平行
                    * 而Graphics.TranslateTransform方法，是沿着x，y轴平移的
                    * 因此分三步可以实现中心旋转
                    * 1.把画板(Graphics对象)平移到旋转中心
                    * 2.旋转画板
                    * 3.把画板平移退回相同的距离(此时的x，y轴仍然是与旋转后的矩形平行的)
                    */
                //// 把画板的原点(默认是左上角)定位移到文字中心
                //graphics.TranslateTransform(x1 + sf.Width / 2, y1 + sf.Height / 2);
                //// 旋转画板
                //graphics.RotateTransform(angle);
                //// 回退画板x,y轴移动过的距离
                //graphics.TranslateTransform(-(x1 + sf.Width / 2), -(y1 + sf.Height / 2));

                #endregion

                #region 法二：矩阵旋转

                var rf = new RectangleF(locationLeftTop, sf);

                var a1 = rf.Location;
                var a2 = new PointF(a1.X, a1.Y + rf.Height);
                var b1 = new PointF(a1.X + rf.Width, a1.Y);
                var b2 = new PointF(a1.X + rf.Width, a1.Y + rf.Height);

                var pos = new PointF[] { a1, a2, b2, b1 };

                //matrix = new Matrix(rf, pos);

                matrix.RotateAt(angle, new PointF(x1 + sf.Width / 2, y1 + sf.Height / 2));


                #endregion
            }

            // 写上自定义角度的文字
            graphics.DrawString(text, font, new SolidBrush(Color.Black), x1, y1);

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

                CircleBuaGuaByPointF(graph, pointF, 300, 250, i % 2 == 0, i % 2 == 1);

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
