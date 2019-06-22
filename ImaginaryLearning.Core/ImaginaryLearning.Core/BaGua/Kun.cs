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
            ChuYao = new YinYao(startPoint, totalWidth, midWidth, heigth);

            ErYao = new YinYao(new Point(startPoint.X, startPoint.Y + 2 * heigth), totalWidth, midWidth, heigth);

            SanYao = new YinYao(new Point(startPoint.X, startPoint.Y + 4 * heigth), totalWidth, midWidth, heigth);

            Name = "坤";
        }
    }
}
