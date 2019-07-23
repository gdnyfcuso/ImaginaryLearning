using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Common
{
    public static class CircleExtension
    {
        /// <summary>
        /// 计算圆上谋一个角度的坐标
        /// </summary>
        /// <param name="sPoint"></param>
        /// <param name="angle"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public static PointF CirclePointF(this PointF sPoint, float angle, float r)
        {
            //var x = -33204.0924438;  //圆心x

            //var y = -9512.41208658; //圆心y

            //var r = 1000;//半径



            //var angle = 30;//角度

            var x = sPoint.X;
            var y = sPoint.Y;

            var tmpX = x + r * Math.Cos(angle * 3.14 / 180);
            var tempyy = r * Math.Sin(angle * 3.14 / 180);
            var tmpY = 0f;
            if (tempyy - y > 0)
            {
                tmpY = y - (float)tempyy;
            }
            else
            {
                tmpY = y + (float)tempyy;
            }



            return new PointF((float)tmpX, (float)tmpY);

        }

        /// <summary>
        /// 计算圆上谋一个角度的坐标
        /// </summary>
        /// <param name="sPoint"></param>
        /// <param name="angle"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public static Point CirclePoint(this Point sPoint, int angle, float r)
        {
            //var x = -33204.0924438;  //圆心x

            //var y = -9512.41208658; //圆心y

            //var r = 1000;//半径



            //var angle = 30;//角度

            var x = sPoint.X;
            var y = sPoint.Y;

            var tmpX = x + r * Math.Cos(angle * 3.14 / 180);
            var tmpY = y + r * Math.Sin(angle * 3.14 / 180);

            return new Point((int)tmpX, (int)tmpY);

        }
    }
}
