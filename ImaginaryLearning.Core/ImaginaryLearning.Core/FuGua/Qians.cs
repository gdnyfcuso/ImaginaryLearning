using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 六十四卦的乾卦，由两个单乾卦上下组而成
    /// </summary>
    public class Qians : FuGua
    {
        public Qians(Point startPoint, int totalWidth, int midWidth, int heigth)
        {
            XiaGua = new Qian(CreateXiaGuaPoint(startPoint, heigth), totalWidth, heigth);
            ShangGua = new Qian(startPoint, totalWidth, heigth);
            Name = "乾";
        }

    }
}
