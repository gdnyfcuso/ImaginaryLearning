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
            Name = "离";
        }
    }
}
