using ImaginaryLearning.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core.Model
{
    public class YaoRectangleF : YaoRectangleBase<PointF>, IEquatable<YaoRectangleF>
    {
        public RectangleF SourceRectangleF { get; set; }


        /// <summary>
        /// 根据正常的矩形计算旋转一定角度之后的四个点的坐标
        /// </summary>
        /// <param name="rectangleF">矩形表示区域</param>
        /// <param name="angle">要旋转的角度</param>
        /// <param name="circleCentPointF">围绕旋转的圆心</param>
        public YaoRectangleF(RectangleF rectangleF, int angle, PointF circleCentPointF)
        {
            var ps = circleCentPointF.RectangularRotationForCircleCentPointF(angle, rectangleF);
            LeftUpPoint = ps[0];
            LeftDownPoint = ps[1];
            RightDownPoint = ps[2];
            RightUpPoint = ps[3];
            SourceRectangleF = rectangleF;
        }


        public PointF[] FillPolygonPointF
        {
            get
            {
                return new PointF[] { LeftUpPoint, LeftDownPoint, RightDownPoint, RightUpPoint };
            }
        }

        public bool Equals(YaoRectangleF other)
        {
            return other.LeftDownPoint == this.LeftDownPoint && other.LeftUpPoint == this.LeftUpPoint && other.RightUpPoint == RightUpPoint && other.RightDownPoint == RightDownPoint;
        }
    }
}
