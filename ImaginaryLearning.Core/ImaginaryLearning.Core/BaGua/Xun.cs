using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core.BaGua
{
    /// <summary>
    /// 巽 
    /// </summary>
    public class Xun : DanGua
    {
        public Xun(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            SanYao = new YangYao(startPoint, totalWidth, heigth);
            ErYao = new YangYao(CreateSecondPoint(startPoint, heigth), totalWidth, heigth);
            ChuYao = new YinYao(CreateThirdPoint(startPoint,heigth), totalWidth, midWidth, heigth);
            GuaRectangle = GetGuaRectangle(totalWidth, heigth, midWidth);
            Name = "巽";
            Nature = "风";

            InnateNumber = 5;
            NumbersAcquired = 4;
            InnateOrientation = BaGuaDirection.XN;// "西南";
            AcquiredAzimuth = BaGuaDirection.DN;// "东南";

        }

        public Xun(PointF startPoint) : this(startPoint, GuaConst.TotalWidth, GuaConst.MidWidth, GuaConst.Heigth)
        {

        }

        public Xun() : this(new PointF() { X = GuaConst.Start_Point_X, Y = GuaConst.Start_Point_Y })
        {

        }
    }
}
