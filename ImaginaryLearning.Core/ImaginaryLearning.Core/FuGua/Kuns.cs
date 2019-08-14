using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 坤卦，复卦
    /// </summary>
    public class Kuns : FuGua
    {
        public Kuns(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {

        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            XiaGua = new Kun(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            ShangGua = new Kun(startPoint, totalWidth, midWidth, heigth);
            Name = "坤";
            IsTwelvePIGua = true;
        }
    }
}
