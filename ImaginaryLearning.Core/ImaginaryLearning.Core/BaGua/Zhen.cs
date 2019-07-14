using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core.BaGua
{
    /// <summary>
    /// 震
    /// </summary>
    public class Zhen : DanGua
    {
        public Zhen(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ChuYao = new YangYao(CreateThirdPoint(startPoint, heigth), totalWidth, heigth);
            ErYao = new YinYao(CreateSecondPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            SanYao = new YinYao(startPoint, totalWidth, midWidth, heigth);
            GuaRectangle = GetGuaRectangle(totalWidth, heigth, midWidth);
            Name = "震";
            Nature = "雷";

            InnateNumber = 4;
            NumbersAcquired = 3;
            InnateOrientation = BaGuaDirection.DB;// "南";
            AcquiredAzimuth = BaGuaDirection.ZD;
        }

        public Zhen(Point startPoint) : this(startPoint, GuaConst.TotalWidth, GuaConst.MidWidth, GuaConst.Heigth)
        {

        }

        public Zhen() : this(new Point() { X = GuaConst.Start_Point_X, Y = GuaConst.Start_Point_Y })
        {

        }
    }
}
