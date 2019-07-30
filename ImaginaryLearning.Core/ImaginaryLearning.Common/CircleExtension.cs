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
        /// 矩形绕一个圆心旋转
        /// </summary>
        /// <returns></returns>
        public static PointF[] RectangularRotationForCircleCentPointF(this PointF centPointF, int angleO, RectangleF rectangleF)
        {
            var o = centPointF;
            var angle = angleO;

            var leftSPoint = rectangleF.Location;
            var leftXPoint = new PointF(rectangleF.X, rectangleF.Y + rectangleF.Height);
            var rightSpoint = new PointF(rectangleF.X + rectangleF.Width, rectangleF.Y);
            var rightXpoint = new PointF(rectangleF.X + rectangleF.Width, rectangleF.Y + rectangleF.Height);

            var thirtPoint = new PointF(o.X + 100, o.Y);

            var leftSangs = GetAngleByThirtPointF(o, leftSPoint, thirtPoint);
            var leftSangx = GetAngleByThirtPointF(o, leftXPoint, thirtPoint);
            var rightSangs = GetAngleByThirtPointF(o, rightSpoint, thirtPoint);
            var rightSangx = GetAngleByThirtPointF(o, rightXpoint, thirtPoint);

            var ang = angle;
            var ps = new PointF[4];
            double leftSPointvalue = Math.Sqrt(Math.Abs(o.X - leftSPoint.X) * Math.Abs(o.X - leftSPoint.X) + Math.Abs(o.Y - leftSPoint.Y) * Math.Abs(o.Y - leftSPoint.Y));
            //var leftSang = GetAngleByThirtPointF(o, leftSPoint, rightSpoint);
            if (leftSPoint.Y > o.Y)
            {
                var leftSPoint1 = o.CirclePointF(ang - leftSangs, (float)leftSPointvalue);
                ps[0] = leftSPoint1;
            }
            else
            {
                var leftSPoint1 = o.CirclePointF(ang + leftSangs, (float)leftSPointvalue);
                ps[0] = leftSPoint1;
            }

            double leftXPointvalue = Math.Sqrt(Math.Abs(o.X - leftXPoint.X) * Math.Abs(o.X - leftXPoint.X) + Math.Abs(o.Y - leftXPoint.Y) * Math.Abs(o.Y - leftXPoint.Y));

            if (leftXPoint.Y > o.Y)
            //var lefXtang = GetAngleByThirtPointF(o, leftSPoint, leftXPoint);
            {
                var leftXPoint1 = o.CirclePointF(ang - leftSangx, (float)leftXPointvalue);
                ps[1] = leftXPoint1;
            }
            else
            {
                var leftXPoint1 = o.CirclePointF(ang + leftSangx, (float)leftXPointvalue);
                ps[1] = leftXPoint1;
            }


            double rightSpointvalue = Math.Sqrt(Math.Abs(o.X - rightSpoint.X) * Math.Abs(o.X - rightSpoint.X) + Math.Abs(o.Y - rightSpoint.Y) * Math.Abs(o.Y - rightSpoint.Y));
            //var rightstang = GetAngleByThirtPointF(o, leftSPoint, rightSpoint);
            if (rightSpoint.Y > o.Y)
            {
                var rightSpoint1 = o.CirclePointF(ang - rightSangs, (float)rightSpointvalue);
                ps[3]=rightSpoint1;
            }
            else {
                var rightSpoint1 = o.CirclePointF(ang + rightSangs, (float)rightSpointvalue);
                ps[3] = rightSpoint1;
            }

            


            double rightXpointvalue = Math.Sqrt(Math.Abs(o.X - rightXpoint.X) * Math.Abs(o.X - rightXpoint.X) + Math.Abs(o.Y - rightXpoint.Y) * Math.Abs(o.Y - rightXpoint.Y));
            //var rightxtang = GetAngleByThirtPointF(o, rightXpoint, rightSpoint);

            if (rightXpoint.Y > o.Y)
            {
                var rightXpoint1 = o.CirclePointF(ang - rightSangx, (float)rightXpointvalue);
                ps[2] = rightXpoint1;
            }
            else {
                var rightXpoint1 = o.CirclePointF(ang + rightSangx, (float)rightXpointvalue);
                ps[2] = rightXpoint1;
            }
            

            //var ps = new PointF[] { leftSPoint1, leftXPoint1, rightXpoint1, rightSpoint1 };

            return ps;
        }

        /// <summary>
        /// 求三个点之间的夹角是多少
        /// </summary>
        /// <param name="cen">中间的点</param>
        /// <param name="first">第一个点</param>
        /// <param name="second">第三个点</param>
        /// <returns></returns>
        public static float GetAngleByThirtPointF(this PointF cen, PointF first, PointF second)
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
