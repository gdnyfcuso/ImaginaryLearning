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
        public Xun(Point startPoint, int totalWidth, int midWidth, int heigth)
        {
            SanYao = new YangYao(startPoint, totalWidth, heigth);
            ErYao = new YangYao(CreateSecondPoint(startPoint, heigth), totalWidth, heigth);
            ChuYao = new YinYao(CreateThirdPoint(startPoint,heigth), totalWidth, midWidth, heigth);
            GuaRectangle = GetGuaRectangle(totalWidth, heigth, midWidth);
            Name = "巽";

        }

        public Xun(Point startPoint) : this(startPoint, GuaConst.TotalWidth, GuaConst.MidWidth, GuaConst.Heigth)
        {

        }

        public Xun() : this(new Point() { X = GuaConst.Start_Point_X, Y = GuaConst.Start_Point_Y })
        {

        }
    }
}
