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
        public Bitmap CreateLiuSiGuaCircleBitmap(Bitmap sourceBitmap, int totalWidth, int midWidth, int heigth, int r = 0)
        {
            var o = new PointF() { X = sourceBitmap.Width / 2, Y = sourceBitmap.Height / 2 };

            InitLiuSiGuaNewPoint(o, totalWidth, midWidth, heigth, r);
            List<FuGua> liusbitmap = GetXianTianXuGuaList();

            List<FuGua> liusiZ = GetLiuSiGuaList(liusbitmap);
            Graphics graph = Graphics.FromImage(sourceBitmap);
            Brush white = new SolidBrush(Color.Green);

            graph.FillRectangle(white, new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height));
            for (int i = 0; i < liusiZ.Count; i++)
            {
                Matrix matrix = graph.Transform;

                Font font = new Font("宋体", 50, GraphicsUnit.Pixel);
                SizeF sf = graph.MeasureString(liusiZ[i].Name, font); // 计算出来文字所占矩形区域
                                                                      //matrix.RotateAt(45, pointF);
                                                                      //graph.FillEllipse(Brushes.Red, new RectangleF(new PointF(0, 0), new SizeF() { Width = 10, Height = 10 }));
                                                                      //graph.FillEllipse(Brushes.Blue, new RectangleF(o, new SizeF(10, 10)));
                                                                      //var rf = new RectangleF(500 - sf.Width / 2, 100 - sf.Height / 2, sf.Width, sf.Height);
                                                                      //graph.FillRectangle(Brushes.Gray, rf);
                                                                      //graph.DrawLine(Pens.Red, 500, 500, 500, 100);
                graph.DrawString(liusiZ[i].Name, font, Brushes.Red, new RectangleF(o.X - sf.Width / 2, o.Y - r - 20 - sf.Height / 2, sf.Width, sf.Height));
                graph.DrawRectangles(new Pen(Brushes.Red), liusiZ[i].ShangGua.RectangleList.ToArray());
                graph.FillRectangles(Brushes.Red, liusiZ[i].ShangGua.RectangleList.ToArray());
                graph.DrawRectangles(new Pen(Brushes.Red), liusiZ[i].XiaGua.RectangleList.ToArray());
                graph.FillRectangles(Brushes.Red, liusiZ[i].XiaGua.RectangleList.ToArray());
                //graph.DrawRectangles(new Pen(Brushes.Red), liusiZ[i].XiaGua.RectangleList.ToArray());
                matrix.RotateAt(-5.625f, o);

                graph.Transform = matrix;

            }

            return sourceBitmap;
        }

        private static List<FuGua> GetXianTianXuGuaList()
        {
            var liusbitmap = FuGua.FuGuaDic.Values.ToList();
            liusbitmap.Sort((a, b) =>
            {
                return a.GetFuGuaXiangTianNumber() - b.GetFuGuaXiangTianNumber();
            });
            return liusbitmap;
        }

        public Bitmap CreateLiuSiguaRectangleBitmap(Bitmap sourceBitmap, int totalWidth, int midWidth, int heigth)
        {
            var o = new PointF();

            InitLiuSiGua(o, totalWidth, midWidth, heigth);
            var Mylist = GetXianTianXuGuaList();

            Graphics graph = Graphics.FromImage(sourceBitmap);
            Brush white = new SolidBrush(Color.Green);

            graph.FillRectangle(white, new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height));

            for (int i = 0; i < Mylist.Count; i++)
            {
                var myfugua = Mylist[Mylist.Count - i - 1];
                var guaRectangleF = myfugua.RectangleF;

                Font font = new Font("宋体", (int)(guaRectangleF.Height*3/10), GraphicsUnit.Pixel);
                SizeF sf = graph.MeasureString(myfugua.Name, font); // 计算出来文字所占矩形区域
                                                                    //matrix.RotateAt(45, pointF);
                                                                    //graph.FillEllipse(Brushes.Red, new RectangleF(new PointF(0, 0), new SizeF() { Width = 10, Height = 10 }));
                                                                    //graph.FillEllipse(Brushes.Blue, new RectangleF(o, new SizeF(10, 10)));
                                                                    //var rf = new RectangleF(500 - sf.Width / 2, 100 - sf.Height / 2, sf.Width, sf.Height);
                                                                    //graph.FillRectangle(Brushes.Gray, rf);
                                                                    //graph.DrawLine(Pens.Red, 500, 500, 500, 100);


                var bitmapGua = new Bitmap(Convert.ToInt32(guaRectangleF.Width), Convert.ToInt32(guaRectangleF.Height + sf.Height));

                var guaGraph = Graphics.FromImage(bitmapGua);

                guaGraph.DrawString(myfugua.Name, font, Brushes.Red, new RectangleF((guaRectangleF.Width-sf.Width)/2, guaRectangleF.Height + 20, sf.Width, sf.Height));

                guaGraph.FillRectangle(Brushes.Green, guaRectangleF);
                //guaGraph.DrawRectangles(new Pen(Brushes.Red), Mylist[i].RectangleList.ToArray());
                guaGraph.FillRectangles(Brushes.Red, Mylist[Mylist.Count - i - 1].RectangleList.ToArray());

                //行
                int row = i / 8;
                //列
                int column = i % 8;
                var gwidth = sourceBitmap.Width / 8;

                var gHeigth = sourceBitmap.Height / 8;

                if (guaRectangleF.Width * 1.2 < gwidth && guaRectangleF.Height * 1.2 < gHeigth)
                {
                    var centWidth = (gwidth - guaRectangleF.Width) / 2;
                    var centHeigth = (gHeigth - guaRectangleF.Height) / 2;
                    graph.DrawImage(bitmapGua, new PointF((float)(column * gwidth + centWidth), (float)(row * gHeigth + centHeigth)));
                }

                bitmapGua.Save(Mylist[i].Name + ".bmp");
            }

            return sourceBitmap;
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
