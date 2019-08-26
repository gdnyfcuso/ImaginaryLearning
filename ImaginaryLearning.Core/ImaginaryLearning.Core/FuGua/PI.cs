using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 否卦，天在下，地在上
    /// </summary>
    public class PI : FuGua
    {
        public PI(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {

        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            XiaGua = new Kun(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            ShangGua = new Qian(startPoint, totalWidth, heigth);
            Name = "否";
            PinYin = "Pi";
            IsTwelvePIGua = true;
            XuGua = 12;

        }
    }
}
