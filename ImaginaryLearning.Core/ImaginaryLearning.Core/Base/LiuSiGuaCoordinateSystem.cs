using ImaginaryLearning.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ImaginaryLearning.Core.Base
{
    /// <summary>
    /// 六十四卦所用的坐标系统
    /// </summary>
    public sealed class LiuSiGuaCoordinateSystem
    {
        private List<Color> colorsGua = new List<Color>();
        Brush backBrush = new SolidBrush(Color.DarkGray);
        Brush foreBrush = new SolidBrush(Color.Black);
        Brush fontBrush = new SolidBrush(Color.Red);


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

            AddColors();
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
        /// 可以选择的颜色，动态由程序指定
        /// </summary>
        public void AddColors(List<Color> colors = null)
        {
            colorsGua.Clear();
            if (colors != null)
            {
                colorsGua.AddRange(colors);
            }
            else
            {

                colorsGua.Add(Color.FromArgb(255, 255, 255));//白
                colorsGua.Add(Color.FromArgb(0, 0, 255));//蓝
                colorsGua.Add(Color.FromArgb(255, 0, 0));//红
                colorsGua.Add(Color.FromArgb(0, 255, 0));//绿
                colorsGua.Add(Color.FromArgb(255, 255, 0));//黄
                colorsGua.Add(Color.FromArgb(255, 0, 255));//紫
                colorsGua.Add(Color.FromArgb(0, 0, 0));//黑
                colorsGua.Add(Color.FromArgb(0, 255, 255));//青
            }

            //colorsGua.Add(Color.FromArgb(255, 255, 255));
            //colorsGua.Add(Color.FromArgb(255, 255, 0));
            //colorsGua.Add(Color.FromArgb(255, 0, 255));
            //colorsGua.Add(Color.FromArgb(255, 0, 0));
            //colorsGua.Add(Color.FromArgb(0, 0, 0));
            //colorsGua.Add(Color.FromArgb(0, 255, 255));
            //colorsGua.Add(Color.FromArgb(255, 0, 0));
            //colorsGua.Add(Color.FromArgb(0, 0, 255));

            #region 红色
            //colorsGua.Add(Color.FromArgb(255, 0, 0));
            //colorsGua.Add(Color.FromArgb(255, 28, 0));
            //colorsGua.Add(Color.FromArgb(255, 57, 0));
            //colorsGua.Add(Color.FromArgb(255, 85, 0));
            //colorsGua.Add(Color.FromArgb(255, 198, 0));
            //colorsGua.Add(Color.FromArgb(255, 170, 0));
            //colorsGua.Add(Color.FromArgb(255, 142, 0));
            //colorsGua.Add(Color.FromArgb(255, 113, 0)); 
            #endregion

            //colorsGua.Add(Color.FromArgb(255, 255, 255));
            //colorsGua.Add(Color.FromArgb(255, 255, 0));
            //colorsGua.Add(Color.FromArgb(255, 0, 255));
            //colorsGua.Add(Color.FromArgb(255, 0, 0));
            //colorsGua.Add(Color.FromArgb(0, 255, 255));
            //colorsGua.Add(Color.FromArgb(0, 255, 0));
            //colorsGua.Add(Color.FromArgb(0, 0, 255));
            //colorsGua.Add(Color.FromArgb(0, 0, 0));

            //colorsGua.Add(Color.Red);
            //colorsGua.Add(Color.White);
            //colorsGua.Add(Color.Firebrick);
            //colorsGua.Add(Color.Green);
            //colorsGua.Add(Color.DarkOrange);
            //colorsGua.Add(Color.Yellow);
            //colorsGua.Add(Color.Black);
            //colorsGua.Add(Color.DeepPink);
        }

        /// <summary>
        /// 通过圆心计算卦的起始位置，然后初始化六十四卦的起始位置
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
        ///根据图片的大小计算圆心的位置，图像一般是正方形
        /// </summary>
        /// <param name="sourceBitmap">将六十四卦画的位置</param>
        /// <param name="totalWidth">卦的宽度，阳爻的宽度</param>
        /// <param name="midWidth">阴爻，中间去掉的宽度</param>
        ///<param name="heigth">每一多的高度</param>
        /// <returns></returns>
        public Bitmap CreateLiuSiGuaCircleBitmap(Bitmap sourceBitmap, int totalWidth, int midWidth, int heigth, int r = 0)
        {
            var o = new PointF() { X = sourceBitmap.Width / 2, Y = sourceBitmap.Height / 2 };

            InitLiuSiGuaNewPoint(o, totalWidth, midWidth, heigth, r);
            List<FuGua> liusbitmap = GetXianTianXuGuaList();

            List<FuGua> liusiZ = GetLiuSiGuaList(liusbitmap);
            Graphics graph = Graphics.FromImage(sourceBitmap);

            graph.FillRectangle(backBrush, new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height));
            for (int i = 0; i < liusiZ.Count; i++)
            {
                Matrix matrix = graph.Transform;

                Font font = new Font("宋体", 50, GraphicsUnit.Pixel);
                SizeF sf = graph.MeasureString(liusiZ[i].Name, font); // 计算出来文字所占矩形区域
                graph.DrawString(liusiZ[i].Name, font, fontBrush, new RectangleF(o.X - sf.Width / 2, o.Y - r - 20 - sf.Height / 2, sf.Width, sf.Height));
                int column = i % 8;
                if (i >= 32)
                {


                    if (column < 4)
                    {
                        foreBrush = new SolidBrush(colorsGua[4 + column]);
                    }
                    else
                    {
                        foreBrush = new SolidBrush(colorsGua[8 - column - 1]);
                    }
                }
                else
                {
                    if (column < 4)
                    {
                        foreBrush = new SolidBrush(colorsGua[column]);
                    }
                    else
                    {
                        foreBrush = new SolidBrush(colorsGua[4 + 7 - column]);
                    }
                }
                graph.DrawRectangles(new Pen(foreBrush), liusiZ[i].ShangGua.RectangleList.ToArray());
                graph.FillRectangles(foreBrush, liusiZ[i].ShangGua.RectangleList.ToArray());

                foreBrush = new SolidBrush(colorsGua[Convert.ToInt32(i / 8)]);

                graph.DrawRectangles(new Pen(foreBrush), liusiZ[i].XiaGua.RectangleList.ToArray());
                graph.FillRectangles(foreBrush, liusiZ[i].XiaGua.RectangleList.ToArray());
                //逆时针旋转5.625度
                matrix.RotateAt(-5.625f, o);

                graph.Transform = matrix;

            }

            return sourceBitmap;
        }

        /// <summary>
        /// 将六十四卦按先天卦的顺序排列
        /// </summary>
        /// <returns></returns>
        private List<FuGua> GetXianTianXuGuaList()
        {
            var liusbitmap = FuGua.FuGuaDic.Values.ToList();
            liusbitmap.Sort((a, b) =>
            {
                return a.GetFuGuaXiangTianNumber() - b.GetFuGuaXiangTianNumber();
            });
            return liusbitmap;
        }

        /// <summary>
        /// 计算六十四卦方图
        /// </summary>
        /// <param name="sourceBitmap"></param>
        /// <param name="totalWidth"></param>
        /// <param name="midWidth"></param>
        /// <param name="heigth"></param>
        /// <returns></returns>
        public Bitmap CreateLiuSiguaRectangleBitmap(Bitmap sourceBitmap, int totalWidth, int midWidth, int heigth)
        {
            var o = new PointF();

            InitLiuSiGua(o, totalWidth, midWidth, heigth);
            var Mylist = GetXianTianXuGuaList();

            Graphics graph = Graphics.FromImage(sourceBitmap);
            Brush white = new SolidBrush(Color.Green);

            graph.FillRectangle(backBrush, new RectangleF(0, 0, sourceBitmap.Width, sourceBitmap.Height));

            for (int i = 0; i < Mylist.Count; i++)
            {
                var myfugua = Mylist[Mylist.Count - i - 1];
                var guaRectangleF = myfugua.RectangleF;

                Font font = new Font("宋体", (int)(guaRectangleF.Height / 5), GraphicsUnit.Pixel);
                SizeF sf = graph.MeasureString(myfugua.Name, font); // 计算出来文字所占矩形区域
                                                                    //matrix.RotateAt(45, pointF);
                                                                    //graph.FillEllipse(Brushes.Red, new RectangleF(new PointF(0, 0), new SizeF() { Width = 10, Height = 10 }));
                                                                    //graph.FillEllipse(Brushes.Blue, new RectangleF(o, new SizeF(10, 10)));
                                                                    //var rf = new RectangleF(500 - sf.Width / 2, 100 - sf.Height / 2, sf.Width, sf.Height);
                                                                    //graph.FillRectangle(Brushes.Gray, rf);
                                                                    //graph.DrawLine(Pens.Red, 500, 500, 500, 100);
                                                                    //行


                var bitmapGua = new Bitmap(Convert.ToInt32(guaRectangleF.Width), Convert.ToInt32(guaRectangleF.Height + sf.Height));

                var guaGraph = Graphics.FromImage(bitmapGua);

                guaGraph.DrawString(myfugua.Name, font, fontBrush, new RectangleF((guaRectangleF.Width - sf.Width) / 2, guaRectangleF.Height + guaRectangleF.Height / 100, sf.Width, sf.Height));

                int row = i / 8;
                //列
                int column = i % 8;
                if (column < 4)
                {
                    foreBrush = new SolidBrush(colorsGua[4 + column]);
                }
                else
                {
                    foreBrush = new SolidBrush(colorsGua[8 - column - 1]);
                }

                //foreBrush = new SolidBrush(colorsGua[8 - i % colorsGua.Count - 1]);


                guaGraph.FillRectangle(backBrush, guaRectangleF);
                //guaGraph.DrawRectangles(new Pen(Brushes.Red), Mylist[i].RectangleList.ToArray());

                guaGraph.FillRectangles(foreBrush, Mylist[Mylist.Count - i - 1].ShangGua.RectangleList.ToArray());

                if (i < 32)
                {
                    foreBrush = new SolidBrush(colorsGua[4 + Convert.ToInt32(i / 8)]);
                }
                else
                {
                    foreBrush = new SolidBrush(colorsGua[8 - Convert.ToInt32(i / 8) - 1]);
                }

                //if (i > 31)
                //{
                //    foreBrush = new SolidBrush(colorsGua[4 + Convert.ToInt32(i / 8)]);
                //}
                //else
                //{
                //    foreBrush = new SolidBrush(colorsGua[8 - Convert.ToInt32(i / 8) - 1]);
                //}

                guaGraph.FillRectangles(foreBrush, Mylist[Mylist.Count - i - 1].XiaGua.RectangleList.ToArray());

                ////行
                //int row = i / 8;
                ////列
                //int column = i % 8;
                var gwidth = sourceBitmap.Width / 8;

                var gHeigth = sourceBitmap.Height / 8;

                if (guaRectangleF.Width * 1.2 < gwidth && guaRectangleF.Height * 1.2 < gHeigth)
                {
                    var centWidth = (gwidth - guaRectangleF.Width) / 2;
                    var centHeigth = (gHeigth - guaRectangleF.Height) / 2;
                    graph.DrawImage(bitmapGua, new PointF((float)(column * gwidth + centWidth), (float)(row * gHeigth + centHeigth)));
                }

                //bitmapGua.Save(Mylist[i].Name + ".jpg", ImageFormat.Jpeg);
                bitmapGua.Dispose();
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
        /// 创建六十四卦方圆图
        /// </summary>
        /// <returns></returns>
        public Bitmap CreateLiuSiGuaRectangleCircelBitmap(Bitmap sourceBitmap, float r)
        {
            //计算圆心
            var o = new PointF(sourceBitmap.Width / 2, sourceBitmap.Height / 2);

            var NB = o.CirclePointfForZBC(r) * 2;


            var fGuaWidth = ((NB / 8) * 4) / 5;

            var fGuaHeigth = (NB / 8) / 15;

            var fGuaMidWidth = fGuaWidth / 10;


            var circleR = r + 6 * fGuaHeigth;

            CreateLiuSiGuaCircleBitmap(sourceBitmap, (int)fGuaWidth / 2, (int)fGuaMidWidth / 2, (int)fGuaHeigth / 2, (int)circleR);
            var bitmapRectangle = new Bitmap((int)NB, (int)NB + 20);
            var rectanglePoint = o.CirclePointF(-135, r);
            CreateLiuSiguaRectangleBitmap(bitmapRectangle, (int)fGuaWidth, (int)fGuaMidWidth, (int)fGuaHeigth);

            var graph = Graphics.FromImage(sourceBitmap);
            graph.DrawImage(bitmapRectangle, rectanglePoint);

            return sourceBitmap;
        }

        /// <summary>
        /// 通过数字计算复卦
        /// </summary>
        /// <param name="numA">
        /// 上卦
        /// </param>
        /// <param name="numB">
        /// 下卦
        /// </param>
        /// <returns></returns>
        public FuGua CreateFuGuaByNumber(int numA, int numB)
        {
            int up = (numA - 1) % 8;
            int down = (numB - 1) % 8;

            var upstr = Convert.ToString(up, 2).PadLeft(3, '0');
            var downStr = Convert.ToString(down, 2).PadLeft(3, '0');

            return FuGua.FuGuaDic[downStr + upstr];
        }

        /// <summary>
        /// 通过时间计算复卦
        /// </summary>
        /// <param name="SourceDateTime"></param>
        /// <returns></returns>
        public FuGua CreateFuGuaByDateTime(DateTime SourceDateTime)
        {
            int Hour = SourceDateTime.Hour, diZinum = 0, tianGannum = 0, tianNum = 0, monthNum = 0, yearNum = 0;
            var strtime = string.Empty;
            string nonLiTime = SourceDateTime.GetLunarCalendar(out strtime);

            string[] GetstrTime = strtime.Split('|');
            //以年天干为主的话,把下边的yearNum年数换为tianNum
            tianGannum = GetSuZuValues(GetstrTime[0], YLConvertYinL.TianGan) + 1;
            //2013年蛇年 癸巳 腊月初一日,以年地支为主的话,把tianNum换为yearNum,默认以年地支为主
            yearNum = GetSuZuValues(nonLiTime.Substring(9, 1), YLConvertYinL.DiZhi) + 1;
            monthNum = GetSuZuValues(GetstrTime[1], YLConvertYinL.MonthName);
            tianNum = GetSuZuValues(GetstrTime[2], YLConvertYinL.DayName);
            diZinum = GetDiZhiNum(SourceDateTime);
            int numa = 0; int numb = 0;
            numa = yearNum + monthNum + tianNum;
            numb = yearNum + monthNum + tianNum + diZinum;
            int Up = (yearNum + monthNum + tianNum) % 8;
            int Down = (yearNum + monthNum + tianNum + diZinum) % 8;


            return CreateFuGuaByNumber(Up, Down);
        }

        private int GetSuZuValues(string strname, string[] strarry)
        {
            int i = 0;
            for (i = 0; i < strarry.Length; i++)
            {
                if (strarry[i] == strname)
                {
                    break;
                }
            }
            return i;

        }
        private int GetDiZhiNum(DateTime da)
        {
            int i = 0;

            if (da.Hour % 2 == 0)
            {
                i = da.Hour / 2 + 1;
            }
            else
            {
                i = ((da.Hour + 1) / 2) % 12 + 1;

            }
            return i;

        }


        /// <summary>
        /// 通过当前时间计算复卦
        /// </summary>
        /// <returns></returns>
        public FuGua CreateFuGuaByCurrentDateTime()
        {
            return CreateFuGuaByDateTime(DateTime.Now);
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
