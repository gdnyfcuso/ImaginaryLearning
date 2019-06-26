using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core.BaGua
{
    /// <summary>
    /// 乾卦
    /// </summary>
    public class Qian : DanGua
    {
        public Qian(Point startPoint, int width, int heigth)
        {
            SanYao = new YangYao(startPoint, width, heigth);
            ErYao = new YangYao(new Point(startPoint.X, startPoint.Y + 2 * heigth), width, heigth);
            ChuYao = new YangYao(new Point(startPoint.X, startPoint.Y + 4 * heigth), width, heigth);
            Name = "乾";
        }
    }
}
