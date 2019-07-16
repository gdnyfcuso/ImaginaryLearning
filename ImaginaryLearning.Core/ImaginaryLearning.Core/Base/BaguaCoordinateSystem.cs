using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core.Base
{
    /// <summary>
    /// 八卦中用到的坐标系
    /// </summary>
    public class BaguaCoordinateSystem
    {
        private Dictionary<BaGuaDirection, PointF> directionPoint = new Dictionary<BaGuaDirection, PointF>();

        /// <summary>
        /// 先天八卦
        /// </summary>
        public List<DanGua> XianTianBaGua { get; set; }

        /// <summary>
        /// 后天八卦
        /// </summary>
        public List<DanGua> HouTianBaGua { get; set; }

        /// <summary>
        /// 每一卦的总宽度
        /// </summary>
        public int TotalWidth { get; private set; }


        /// <summary>
        /// 每一爻的总高度
        /// </summary>
        public int Heigth { get; private set; }

        /// <summary>
        /// 如果是阴多的话，中间空白部分的宽度
        /// </summary>
        public int MidWidth { get; private set; }

        /// <summary>
        /// 计算八卦坐标并生成八卦实体
        /// </summary>
        /// <param name="point">圆心坐标</param>
        /// <param name="totalWidth">八卦爻的总宽度</param>
        /// <param name="midWidth">如果是阴爻的话，中间的宽度</param>
        /// <param name="heigth">每一个爻 的宽度</param>
        /// <param name="r"></param>
        public BaguaCoordinateSystem(PointF point, int totalWidth, int midWidth, int heigth, float r = 300)
        {
            XianTianBaGua = new List<DanGua>();
            HouTianBaGua = new List<DanGua>();
            TotalWidth = totalWidth;
            Heigth = heigth;
            MidWidth = midWidth;
            GuaRectangle = DanGua.GetGuaRectangle(totalWidth, heigth, midWidth);
            CircleCenter = point;
            R = r;
            this.GetBaGuaDirectionPoint();
            this.GetBaGuaList();

        }

        /// <summary>
        /// 计算八方对应的八卦方位坐标
        /// </summary>
        /// <param name="GuaRectangle"></param>
        /// <param name="CircleCenter"></param>
        /// <param name="R"></param>
        private void GetBaGuaDirectionPoint()
        {
            var XY = Math.Cos(45 * 3.14 / 180) * R;

            var XNX = XY + CircleCenter.X;
            var XNY = CircleCenter.Y - XY - GuaRectangle.Height;
            XN = new PointF((float)XNX, (float)XNY);

            directionPoint.Add(BaGuaDirection.XN, XN);

            var XBX = XY + CircleCenter.X;
            var XBY = XY + CircleCenter.Y;
            XB = new PointF((float)XBX, (float)XBY);

            directionPoint.Add(BaGuaDirection.XB, XB);

            var DNX = CircleCenter.X - XY - GuaRectangle.Width;
            var DNY = CircleCenter.Y - XY - GuaRectangle.Height;
            DN = new PointF((float)DNX, (float)DNY);

            directionPoint.Add(BaGuaDirection.DN, DN);

            var DBX = CircleCenter.X - XY - GuaRectangle.Width;
            var DBY = CircleCenter.Y + XY;
            DB = new PointF((float)DBX, (float)DBY);

            directionPoint.Add(BaGuaDirection.DB, DB);

            var ZBX = CircleCenter.X - GuaRectangle.Width / 2;
            var ZBY = R + CircleCenter.Y;
            ZB = new PointF((float)ZBX, (float)ZBY);

            directionPoint.Add(BaGuaDirection.ZB, ZB);

            var ZNX = CircleCenter.X - GuaRectangle.Width / 2;
            var ZNY = CircleCenter.Y - R - GuaRectangle.Height;
            ZN = new PointF((float)ZNX, (float)ZNY);

            directionPoint.Add(BaGuaDirection.ZN, ZN);

            var ZDX = CircleCenter.X - R - GuaRectangle.Width;
            var ZDY = CircleCenter.Y - GuaRectangle.Height / 2;
            ZD = new PointF((float)ZDX, (float)ZDY);

            directionPoint.Add(BaGuaDirection.ZD, ZD);

            var ZXX = CircleCenter.X + R;
            var ZXY = CircleCenter.Y - GuaRectangle.Height / 2;
            ZX = new PointF((float)ZXX, (float)ZXY);

            directionPoint.Add(BaGuaDirection.ZX, ZX);
        }

        public static Tuple<List<DanGua>, List<DanGua>> GetBaGuaList(Dictionary<BaGuaDirection, PointF> directionPoint, int totalWidth, int midWidth, int heigth)
        {
            var xtList = new List<DanGua>();
            var htList = new List<DanGua>();

            foreach (var guaDirection in directionPoint.Keys)
            {
                switch (guaDirection)
                {
                    case BaGuaDirection.ZX:
                        var xkan = new Kan(directionPoint[guaDirection], totalWidth, midWidth, heigth);
                        xtList.Add(xkan);
                        var hdui = new Dui(directionPoint[guaDirection], totalWidth, midWidth, heigth);
                        htList.Add(hdui);
                        break;
                    case BaGuaDirection.ZN:
                        var xQian = new Qian(directionPoint[guaDirection], totalWidth, heigth);
                        xtList.Add(xQian);
                        var hLi = new Li(directionPoint[guaDirection], totalWidth, midWidth, heigth);
                        htList.Add(hLi);
                        break;
                    case BaGuaDirection.ZB:
                        var xkun = new Kun(directionPoint[guaDirection], totalWidth, midWidth, heigth);
                        xtList.Add(xkun);
                        var hKan = new Kan(directionPoint[guaDirection], totalWidth, midWidth, heigth);
                        htList.Add(hKan);
                        break;
                    case BaGuaDirection.ZD:
                        var xLi = new Li(directionPoint[guaDirection], totalWidth, midWidth, heigth);
                        xtList.Add(xLi);
                        var hZhen = new Zhen(directionPoint[guaDirection], totalWidth, midWidth, heigth);
                        htList.Add(hZhen);
                        break;
                    case BaGuaDirection.DB:
                        var xZhen = new Zhen(directionPoint[guaDirection], totalWidth, midWidth, heigth);
                        xtList.Add(xZhen);
                        var hGen = new Gen(directionPoint[guaDirection], totalWidth, midWidth, heigth);
                        htList.Add(hGen);
                        break;
                    case BaGuaDirection.DN:
                        var xDui = new Dui(directionPoint[guaDirection], totalWidth, midWidth, heigth);
                        xtList.Add(xDui);
                        var hXun = new Xun(directionPoint[guaDirection], totalWidth, midWidth, heigth);
                        htList.Add(hXun);
                        break;
                    case BaGuaDirection.XB:
                        var xGen = new Gen(directionPoint[guaDirection], totalWidth, midWidth, heigth);
                        xtList.Add(xGen);
                        var hQian = new Qian(directionPoint[guaDirection], totalWidth, heigth);
                        htList.Add(hQian);
                        break;
                    case BaGuaDirection.XN:
                        var xXun = new Xun(directionPoint[guaDirection], totalWidth, midWidth, heigth);
                        xtList.Add(xXun);
                        var hKun = new Kun(directionPoint[guaDirection], totalWidth, midWidth, heigth);
                        htList.Add(hKun);
                        break;
                    default:
                        break;
                }
            }

            var xhTup = new Tuple<List<DanGua>, List<DanGua>>(xtList, htList);
            return xhTup;
        }

        /// <summary>
        /// 调用此方法获取先天八卦后后天八卦的实体对象
        /// </summary>
        public void GetBaGuaList()
        {
            var xhBaGuaList = GetBaGuaList(directionPoint, TotalWidth, MidWidth, Heigth);
            XianTianBaGua = xhBaGuaList.Item1;
            HouTianBaGua = xhBaGuaList.Item2;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="point">圆心坐标</param>
        /// <param name="totalWidth">八卦爻的总宽度</param>
        /// <param name="midWidth">如果是阴爻的话，中间的宽度</param>
        /// <param name="heigth">每一个爻 的宽度</param>
        /// <param name="r"></param>
        public BaguaCoordinateSystem(PointF circleCenterPoint, int r) : this(circleCenterPoint, GuaConst.TotalWidth, GuaConst.MidWidth, GuaConst.Heigth, r)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="point">圆心坐标</param>
        /// <param name="totalWidth">八卦爻的总宽度</param>
        /// <param name="midWidth">如果是阴爻的话，中间的宽度</param>
        /// <param name="heigth">每一个爻 的宽度</param>
        /// <param name="r"></param>
        public BaguaCoordinateSystem(PointF circleCenterPoint) : this(circleCenterPoint, GuaConst.CircleCenterR)
        {

        }

        /// <summary>
        /// 卦的区域，一般长方形表示
        /// </summary>
        public RectangleF GuaRectangle { get; set; }

        /// <summary>
        /// 圆心坐标
        /// </summary>
        public PointF CircleCenter { get; set; }

        /// <summary>
        /// 圆形八卦的半径
        /// </summary>
        public float R { get; set; }

        /// <summary>
        /// 卦的起始位置 正东
        /// </summary>
        public PointF ZD { get; set; }

        /// <summary>
        /// 正西
        /// </summary>
        public PointF ZX { get; set; }


        /// <summary>
        /// 卦的起始位置 正南
        /// </summary>
        public PointF ZN { get; set; }

        /// <summary>
        /// 正北
        /// </summary>
        public PointF ZB { get; set; }

        /// <summary>
        /// 卦的起始位置 东南
        /// </summary>
        public PointF DN { get; set; }

        /// <summary>
        /// 西南
        /// </summary>
        public PointF XN { get; set; }


        /// <summary>
        /// 卦的起始位置 东北
        /// </summary>
        public PointF DB { get; set; }

        /// <summary>
        /// 西北
        /// </summary>
        public PointF XB { get; set; }

    }
}
