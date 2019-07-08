using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
   public class Gou:FuGua
    {
        public Gou(Point startPoint, int totalWidth, int midWidth, int heigth)
        {
            XiaGua = new Xun(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            ShangGua = new Qian(startPoint, totalWidth, heigth);
            Name = "姤";
            IsTwelvePIGua = true;
        }
    }
}
