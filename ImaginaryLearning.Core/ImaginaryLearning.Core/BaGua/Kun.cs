using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core.BaGua
{
    /// <summary>
    /// 坤卦，八单卦之一
    /// </summary>
    public class Kun : DanGua
    {
        public Kun() : this(new System.Drawing.Point() { X = 0, Y = 0 }, 25, 5, 5)
        {

        }

        public Kun(Point startPoint, int totalWidth, int midWidth, int heigth)
        {
            SanYao = new YinYao(startPoint, totalWidth, midWidth, heigth);

            ErYao = new YinYao(CreateSecondPoint(startPoint,heigth), totalWidth, midWidth, heigth);

            ChuYao = new YinYao(CreateThirdPoint(startPoint,heigth), totalWidth, midWidth, heigth);

            Name = "坤";
        }
    }
}
