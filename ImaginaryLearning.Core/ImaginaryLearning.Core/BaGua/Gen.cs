using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core.BaGua
{
    /// <summary>
    /// 艮
    /// </summary>
    public class Gen : DanGua
    {
        public Gen(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ChuYao = new YinYao(CreateThirdPoint(startPoint,heigth),totalWidth,midWidth,heigth);
            ErYao = new YinYao(CreateSecondPoint(startPoint,heigth),totalWidth,midWidth,heigth);
            SanYao = new YangYao(startPoint,totalWidth,heigth);
            GuaRectangle = GetGuaRectangle(totalWidth, heigth, midWidth);
            Name = "艮";
            Nature = "山";
            InnateNumber = 7;
            NumbersAcquired = 8;
            InnateOrientation = BaGuaDirection.XB;// "西北";
            AcquiredAzimuth = BaGuaDirection.DB;// "东北";
        }

        public Gen(PointF startPoint) : this(startPoint, GuaConst.TotalWidth, GuaConst.MidWidth, GuaConst.Heigth)
        {

        }

        public Gen() : this(new PointF() { X = GuaConst.Start_Point_X, Y = GuaConst.Start_Point_Y })
        {

        }
    }
}
