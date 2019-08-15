using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core.BaGua
{
    /// <summary>
    /// 坤卦，八单卦之一
    /// </summary>
    public class Kun : DanGua
    {
        public Kun(PointF startPoint) : this(startPoint, GuaConst.TotalWidth, GuaConst.MidWidth, GuaConst.Heigth)
        {

        }

        public Kun() : this(new PointF() { X = GuaConst.Start_Point_X, Y = GuaConst.Start_Point_Y })
        {

        }

        public Kun(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            SanYao = new YinYao(startPoint, totalWidth, midWidth, heigth);

            ErYao = new YinYao(CreateSecondPoint(startPoint, heigth), totalWidth, midWidth, heigth);

            ChuYao = new YinYao(CreateThirdPoint(startPoint, heigth), totalWidth, midWidth, heigth);

            GuaRectangle = GetGuaRectangle(totalWidth, heigth, midWidth);

            Name = "坤";
            Nature = "地";
            WuXingNature = "土";
            InnateNumber = 8;
            NumbersAcquired = 2;
            InnateOrientation = BaGuaDirection.ZB;// "北";
            AcquiredAzimuth = BaGuaDirection.XN;// "西南";
        }
    }
}
