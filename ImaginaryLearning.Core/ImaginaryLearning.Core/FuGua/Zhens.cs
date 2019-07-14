using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 震卦，六十四卦之一
    /// </summary>
    public class Zhens : FuGua
    {
        public Zhens(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            XiaGua = new Zhen(CreateXiaGuaPoint(startPoint,heigth),totalWidth,midWidth,heigth);
            ShangGua = new Zhen(startPoint,totalWidth,midWidth,heigth);
            Name = "震";
            IsTwelvePIGua = true;
        }
    }
}
