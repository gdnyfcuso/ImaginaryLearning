using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ImaginaryLearning.Core.Base
{
    /// <summary>
    /// 六十四卦所用的坐标系统
    /// </summary>
    public class LiuSiGuaCoordinateSystem
    {
        /// <summary>
        /// 第一次初始化
        /// </summary>
        /// <param name="point">圆心坐标</param>
        /// <param name="totalWidth">爻的总宽度</param>
        /// <param name="midWidth">阴爻空白区域的宽度</param>
        /// <param name="heigth">爻的高度</param>
        /// <param name="r">半径=0的话point复卦的起始点用，不等于0的话当圆心中</param>
        public LiuSiGuaCoordinateSystem(PointF point, int totalWidth, int midWidth, int heigth, int r = 0)
        {
            if (FuGua.FuGuaDic.Count == 0)
            {
                if (r == 0)
                {
                    InitLiuSiGua(point, totalWidth, midWidth, heigth);
                }
                else
                {
                    InitLiuSiGuaNewPoint(point, totalWidth, midWidth, heigth, r);
                }
            }
        }

        /// <summary>
        /// 通过圆心计算卦的起始位置
        /// </summary>
        /// <param name="point"></param>
        /// <param name="totalWidth"></param>
        /// <param name="midWidth"></param>
        /// <param name="heigth"></param>
        /// <param name="r"></param>
        private void InitLiuSiGuaNewPoint(PointF point, int totalWidth, int midWidth, int heigth, int r = 300)
        {
            var guaStartPoing = new PointF(point.X - (totalWidth / 2), point.Y - r);
            InitLiuSiGua(guaStartPoing, totalWidth, midWidth, heigth);
        }

        /// <summary>
        /// 无圆心计算
        /// </summary>
        /// <param name="point"></param>
        /// <param name="totalWidth"></param>
        /// <param name="midWidth"></param>
        /// <param name="heigth"></param>
        private void InitLiuSiGua(PointF point, int totalWidth, int midWidth, int heigth)
        {
            var fuguaAssembly = Assembly.Load(Assembly.GetExecutingAssembly().FullName);
            fuguaAssembly.GetTypes().ToList().ForEach(i =>
            {
                if (i.IsClass && i.IsPublic && i.IsSubclassOf(typeof(FuGua)))
                {
                    var p = Activator.CreateInstance(i, new object[] { point, totalWidth, midWidth, heigth });
                }
            });
        }

        /// <summary>
        ///创建六十四卦圆图
        /// </summary>
        /// <returns></returns>
        public Bitmap CreateLiuSiGuaBitmap(Bitmap sourceBitmap, PointF point, int totalWidth, int midWidth, int heigth, int r = 0)
        {
            InitLiuSiGuaNewPoint(point, totalWidth, midWidth, heigth, r);
            var liusbitmap = FuGua.FuGuaDic.Values.ToList();
            liusbitmap.Sort((a, b) =>
            {
                return a.GetFuGuaXiangTianNumber() - b.GetFuGuaXiangTianNumber();
            });

            List<FuGua> liusiZ = GetLiuSiGuaList(liusbitmap);

            Bitmap image = new Bitmap(1000, 1000);
            var o = new PointF() { X = 500, Y = 500 };
            Graphics graph = Graphics.FromImage(image);


            for (int i = 0; i < liusiZ.Count; i++)
            {
                Matrix matrix = graph.Transform;

                Font font = new Font("宋体", 22, GraphicsUnit.Pixel);
                SizeF sf = graph.MeasureString(liusiZ[i].Name, font); // 计算出来文字所占矩形区域
                                                                      //matrix.RotateAt(45, pointF);
                                                                      //graph.FillEllipse(Brushes.Red, new RectangleF(new PointF(0, 0), new SizeF() { Width = 10, Height = 10 }));
                                                                      //graph.FillEllipse(Brushes.Blue, new RectangleF(o, new SizeF(10, 10)));
                //var rf = new RectangleF(500 - sf.Width / 2, 100 - sf.Height / 2, sf.Width, sf.Height);
                //graph.FillRectangle(Brushes.Gray, rf);
                //graph.DrawLine(Pens.Red, 500, 500, 500, 100);
                graph.DrawString(liusiZ[i].Name, font, Brushes.Red, new RectangleF(500 - sf.Width / 2, 100 - sf.Height / 2, sf.Width, sf.Height));
                //graph.DrawRectangles(new Pen(Brushes.Red), liusiZ[i].ShangGua.RectangleList.ToArray());
                //graph.DrawRectangles(new Pen(Brushes.Red), liusiZ[i].XiaGua.RectangleList.ToArray());
                matrix.RotateAt(-5.625f, new PointF() { X = 500, Y = 500 });

                graph.Transform = matrix;

            }



            //graph.TranslateTransform(500, 500);



            image.Save("mat.bmp");

            return null;
        }

        private static List<FuGua> GetLiuSiGuaList(List<FuGua> liusbitmap)
        {
            var liusi1 = new List<FuGua>();
            var liusi2 = new List<FuGua>();
            FuGua[] fuGuas = new FuGua[32];
            liusbitmap.CopyTo(0, fuGuas, 0, count: 32);
            liusi1.AddRange(fuGuas.ToList());
            fuGuas = new FuGua[32];
            liusbitmap.CopyTo(32, fuGuas, 0, 32);
            liusi2.AddRange(fuGuas.ToList());
            liusi2.Sort((a, b) =>
            {
                return b.GetFuGuaXiangTianNumber() - a.GetFuGuaXiangTianNumber();
            });

            var liusiZ = new List<FuGua>();
            liusiZ.AddRange(liusi1);
            liusiZ.AddRange(liusi2);
            //liusiZ.Add(liusbitmap[0]);
            return liusiZ;
        }

        /// <summary>
        /// 创建六十四卦方图
        /// </summary>
        /// <returns></returns>
        public Bitmap CreateLiuSiGuaRectangleBitmap(Bitmap sourceBitmap)
        {
            return null;
        }

        /// <summary>
        /// 通过数字计算复卦
        /// </summary>
        /// <returns></returns>
        public FuGua CreateFuGuaByNumber()
        {
            return null;
        }

        /// <summary>
        /// 通过时间计算复卦
        /// </summary>
        /// <param name="SourceDateTime"></param>
        /// <returns></returns>
        public FuGua CreateFuGuaByDateTime(DateTime SourceDateTime)
        {
            return null;
        }

        /// <summary>
        /// 通过当前时间计算复卦
        /// </summary>
        /// <returns></returns>
        public FuGua CreateFuGuaByCurrentDateTime()
        {
            return null;
        }

        /// <summary>
        /// 通过手机号计算复卦
        /// </summary>
        /// <returns></returns>
        public FuGua CreateFuGuaByPhoneNumber()
        {
            return null;
        }

        /// <summary>
        /// 通过车牌号计算复卦
        /// </summary>
        /// <returns></returns>
        public FuGua CreateFuGuaByCarCard()
        {
            return null;
        }

        /// <summary>
        /// 将复卦画到图像上去
        /// </summary>
        /// <param name="sourceBitmap"></param>
        /// <returns></returns>
        public Bitmap DrawingFuGuaToBitmap(Bitmap sourceBitmap)
        {
            return null;
        }
    }
}
