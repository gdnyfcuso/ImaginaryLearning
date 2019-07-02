using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core.BaGua
{
    /// <summary>
    /// 泽
    /// </summary>
    public class Dui : DanGua
    {
        public Dui(Point startPoint, int totalWidth, int midWidth, int heigth)
        {
            ChuYao = new YangYao(CreateThirdPoint(startPoint, heigth), totalWidth, heigth);
            ErYao = new YangYao(CreateSecondPoint(startPoint, heigth), totalWidth, heigth);
            SanYao = new YinYao(startPoint, totalWidth, midWidth, heigth);
            GuaRectangle = GetGuaRectangle(totalWidth, heigth, midWidth);
            Name = "泽";
        }

        public Dui(Point startPoint) : this(startPoint, GuaConst.TotalWidth, GuaConst.MidWidth, GuaConst.Heigth)
        {

        }

        public Dui() : this(new Point() { X = GuaConst.Start_Point_X, Y = GuaConst.Start_Point_Y })
        {

        }
    }
}
