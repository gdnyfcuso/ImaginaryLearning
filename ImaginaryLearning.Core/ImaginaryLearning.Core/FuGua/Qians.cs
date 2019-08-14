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
        public Qians(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {

        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            XiaGua = new Qian(CreateXiaGuaPoint(startPoint, heigth), totalWidth, heigth);
            ShangGua = new Qian(startPoint, totalWidth, heigth);
            Name = "乾";
            IsTwelvePIGua = true;
            YaoCi = new string[]
            {
                "潜龙勿用。",
                "见（xiàn）龙在田，利见大人。",
                "君子终日乾乾，夕惕若厉，无咎。",
                "或跃在渊，无咎。",
                "飞龙在天，利见大人。",
                "亢龙有悔。",
                "见群龙无首，吉。"
            };
        }
    }
}
