using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core.BaGua
{
    /// <summary>
    /// 乾卦
    /// </summary>
    public class Qian : DanGua
    {
        public Qian(PointF startPoint, int width, int heigth)
        {
            SanYao = new YangYao(startPoint, width, heigth);
            ErYao = new YangYao(new PointF(startPoint.X, startPoint.Y + 2 * heigth), width, heigth);
            ChuYao = new YangYao(new PointF(startPoint.X, startPoint.Y + 4 * heigth), width, heigth);
            GuaRectangle = GetGuaRectangle(width, heigth, 0);
            Name = "乾";
            Nature = "父";
            InnateNumber = 1;
            NumbersAcquired = 6;
            InnateOrientation = BaGuaDirection.ZN;// "南";
            AcquiredAzimuth = BaGuaDirection.XB;// "西北";
        }

        public Qian(PointF startPoint) : this(startPoint, GuaConst.TotalWidth, GuaConst.Heigth)
        {

        }

        public Qian() : this(new PointF() { X = GuaConst.Start_Point_X, Y = GuaConst.Start_Point_Y })
        {

        }
    }
}
