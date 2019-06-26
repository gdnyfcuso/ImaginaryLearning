using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core.BaGua
{
    /// <summary>
    /// 泽
    /// </summary>
   public class Ze:DanGua
    {
        public Ze(Point startPoint, int totalWidth, int midWidth, int heigth)
        {
            ChuYao = new YangYao(CreateThirdPoint(startPoint,heigth),totalWidth,heigth);
            ErYao = new YangYao(CreateSecondPoint(startPoint,heigth),totalWidth,heigth);
            SanYao = new YinYao(startPoint,totalWidth,midWidth,heigth);
        }
    }
}
