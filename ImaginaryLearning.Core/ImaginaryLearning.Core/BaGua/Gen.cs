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
        public Gen(Point startPoint, int totalWidth, int midWidth, int heigth)
        {
            ChuYao = new YinYao(CreateThirdPoint(startPoint,heigth),totalWidth,midWidth,heigth);
            ErYao = new YinYao(CreateSecondPoint(startPoint,heigth),totalWidth,midWidth,heigth);
            SanYao = new YangYao(startPoint,totalWidth,heigth);
            Name = "艮";
        }
    }
}
