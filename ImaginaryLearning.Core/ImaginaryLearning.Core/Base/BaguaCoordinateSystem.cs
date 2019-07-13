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
        //var x = -33204.0924438;  //圆心x

        //var y = -9512.41208658; //圆心y

        //var r = 1000;//半径



        //var angle = 30;//角度

        //var tmpX = x + r * Math.Cos(angle * 3.14 / 180);
        //var tmpY = y + r * Math.Sin(angle * 3.14 / 180);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="point">圆心坐标</param>
        /// <param name="totalWidth">八卦爻的总宽度</param>
        /// <param name="midWidth">如果是阴爻的话，中间的宽度</param>
        /// <param name="heigth">每一个爻 的宽度</param>
        /// <param name="r"></param>
        public BaguaCoordinateSystem(Point point, int totalWidth, int midWidth, int heigth, int r = 300)
        {
            GuaRectangle = DanGua.GetGuaRectangle(totalWidth, heigth, midWidth);
            CircleCenter = point;
            R = r;

        }

        /// <summary>
        /// 计算八方对应的八卦方位坐标
        /// </summary>
        /// <param name="rectangle"></param>
        /// <param name="circleCenterPoint"></param>
        /// <param name="r"></param>
        private void GetBaGuaDirectionPoint(Rectangle rectangle, Point circleCenterPoint, int r)
        {
            var XY = Math.Cos(45) * r;

            var XNX = XY + circleCenterPoint.X;
            var XNY = circleCenterPoint.Y - XY - rectangle.Height;
            XN = new Point((int)XNX, (int)XNY);

            var XBX = XY + circleCenterPoint.X;
            var XBY = XY + circleCenterPoint.Y;
            XB = new Point((int)XBX, (int)XBY);

            var DNX = circleCenterPoint.X - XY - rectangle.Width;
            var DNY = circleCenterPoint.Y - XY - rectangle.Height;
            DN = new Point((int)DNX, (int)DNY);

            var DBX = circleCenterPoint.X - XY - rectangle.Width;
            var DBY = circleCenterPoint.Y + XY;
            DN = new Point((int)DBX, (int)DBY);

            var ZBX = circleCenterPoint.X - rectangle.Width / 2;
            var ZBY = r + circleCenterPoint.Y;
            ZB = new Point((int)ZBX, (int)ZBY);

            var ZNX = circleCenterPoint.X - rectangle.Width / 2;
            var ZNY = circleCenterPoint.Y - r;
            ZN = new Point((int)ZNX, (int)ZNY);

            var ZDX = circleCenterPoint.X - r - rectangle.Width;
            var ZDY = circleCenterPoint.Y - rectangle.Height / 2;
            ZD = new Point((int)ZDX, (int)ZDY);

            var ZXX = circleCenterPoint.X + r;
            var ZXY = circleCenterPoint.Y - rectangle.Height / 2;
            ZX = new Point((int)ZXX, (int)ZXY);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="point">圆心坐标</param>
        /// <param name="totalWidth">八卦爻的总宽度</param>
        /// <param name="midWidth">如果是阴爻的话，中间的宽度</param>
        /// <param name="heigth">每一个爻 的宽度</param>
        /// <param name="r"></param>
        public BaguaCoordinateSystem(Point circleCenterPoint, int r) : this(circleCenterPoint, GuaConst.TotalWidth, GuaConst.MidWidth, GuaConst.Heigth, r)
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
        public BaguaCoordinateSystem(Point circleCenterPoint) : this(circleCenterPoint, GuaConst.CircleCenterR)
        {

        }

        /// <summary>
        /// 卦的区域，一般长方形表示
        /// </summary>
        public Rectangle GuaRectangle { get; set; }

        /// <summary>
        /// 圆心坐标
        /// </summary>
        public Point CircleCenter { get; set; }

        /// <summary>
        /// 圆形八卦的半径
        /// </summary>
        public int R { get; set; }

        /// <summary>
        /// 卦的起始位置 正东
        /// </summary>
        public Point ZD { get; set; }

        /// <summary>
        /// 正西
        /// </summary>
        public Point ZX { get; set; }


        /// <summary>
        /// 卦的起始位置 正南
        /// </summary>
        public Point ZN { get; set; }

        /// <summary>
        /// 正北
        /// </summary>
        public Point ZB { get; set; }

        /// <summary>
        /// 卦的起始位置 东南
        /// </summary>
        public Point DN { get; set; }

        /// <summary>
        /// 西南
        /// </summary>
        public Point XN { get; set; }


        /// <summary>
        /// 卦的起始位置 东北
        /// </summary>
        public Point DB { get; set; }

        /// <summary>
        /// 西北
        /// </summary>
        public Point XB { get; set; }

    }
}
