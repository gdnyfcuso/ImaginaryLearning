using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core.BaGua
{
    /// <summary>
    /// 离
    /// </summary>
    public class Li : DanGua
    {
        public Li(Point startPoint, int totalWidth, int midWidth, int heigth)
        {
            SanYao = new YangYao(startPoint, totalWidth, heigth);
            ErYao = new YinYao(CreateSecondPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            ChuYao = new YangYao(CreateThirdPoint(startPoint, heigth), totalWidth, heigth);

            GuaRectangle = GetGuaRectangle(totalWidth, heigth, midWidth);

            Name = "离";

            Nature = "火";
        }

        public Li(Point startPoint) : this(startPoint, GuaConst.TotalWidth, GuaConst.MidWidth, GuaConst.Heigth)
        {

        }

        public Li() : this(new Point() { X = GuaConst.Start_Point_X, Y = GuaConst.Start_Point_Y })
        {

        }
    }
}
