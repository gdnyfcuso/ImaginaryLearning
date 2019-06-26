using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core.BaGua
{
    /// <summary>
    /// 坎
    /// </summary>
    public class Kan : DanGua
    {
        public Kan(Point startPoint, int totalWidth, int midWidth, int heigth)
        {
            SanYao = new YinYao(startPoint, totalWidth, midWidth, heigth);
            ErYao = new YangYao(CreateSecondPoint(startPoint, heigth), totalWidth, heigth);
            ChuYao = new YinYao(CreateThirdPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            Name = "坎";
        }
    }
}
