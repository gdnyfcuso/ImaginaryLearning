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
        /// <param name="centPoint">圆心</param>
        /// <param name="angle"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public static PointF CirclePointF(this PointF centPoint, float angle, float r)
        {
            //var x = -33204.0924438;  //圆心x

            //var y = -9512.41208658; //圆心y

            //var r = 1000;//半径



            //var angle = 30;//角度

            var x = centPoint.X;
            var y = centPoint.Y;

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

        /// <summary>
        /// 一个点绕另一个点顺时针旋转
        /// </summary>
        /// <param name="centPoint">圆心</param>
        /// <param name="rotate">另一个点</param>
        /// <param name="angle">旋转的角度0-360</param>
        /// <returns></returns>
        public static Point CirclePointClockwiseRotation(this Point centPoint, Point rotate, int angle)
        {
            //(x1，y1）为要转的点，（x2,y2）为中心点，如果是顺时针角度为θ，

            //x=(x1-x2)cosθ-(y1-y2)sinθ+x2

            //y = (y1 - y2)cosθ+(x1-x2)sinθ+y2

            var myangle = angle * 3.14 / 180;

            var x = (rotate.X - centPoint.X) * Math.Cos(myangle) - (rotate.Y - centPoint.Y) * Math.Sin(myangle) + centPoint.X;
            var y = (rotate.Y - centPoint.Y) * Math.Cos(myangle) + (rotate.X - centPoint.X) + centPoint.Y;
            return new Point((int)x, (int)y);
        }

        /// <summary>
        /// 一个点绕另一个点顺时针旋转
        /// </summary>
        /// <param name="centPoint">圆心</param>
        /// <param name="rotate">另一个点</param>
        /// <param name="angle">旋转的角度0-360</param>
        /// <returns></returns>
        public static PointF CirclePointClockwiseRotationF(this PointF centPoint, PointF rotate, int angle)
        {
            //(x1，y1）为要转的点，（x2,y2）为中心点，如果是顺时针角度为θ，



            //x=(x1-x2)cosθ-(y1-y2)sinθ+x2

            //y = (y1 - y2)cosθ+(x1-x2)sinθ+y2

            var myangle = angle * 3.14 / 180;

            var x = (rotate.X - centPoint.X) * Math.Cos(myangle) - (rotate.Y - centPoint.Y) * Math.Sin(myangle) + centPoint.X;
            var y = (rotate.Y - centPoint.Y) * Math.Cos(myangle) + (rotate.X - centPoint.X) + centPoint.Y;
            return new PointF((float)x, (float)y);
        }
    }
}
