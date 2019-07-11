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

        public BaguaCoordinateSystem(Point point, int r = 300)
        {

        }

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
