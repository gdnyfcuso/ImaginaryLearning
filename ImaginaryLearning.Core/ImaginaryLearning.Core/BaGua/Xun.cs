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
            SanYao = new YinYao(startPoint,totalWidth,midWidth,heigth);
            ErYao = new YangYao(CreateSecondPoint(startPoint,heigth),totalWidth,heigth);
            ChuYao = new YangYao(CreateThirdPoint(startPoint,heigth),totalWidth,heigth);
            Name = "巽";
           
        }
    }
}
