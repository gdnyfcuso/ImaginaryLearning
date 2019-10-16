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
        public Zhens(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            XiaGua = new Zhen(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            ShangGua = new Zhen(startPoint, totalWidth, midWidth, heigth);
            Name = "震";
            PinYin = "Zhen";
            IsTwelvePIGua = true;
            XuGua = 51;
            GuaCi = "亨。震来虩虩，笑言哑哑，震惊百里，不丧匕鬯。";
            GuaXiangCi = "《象》曰：洊雷，震。君子以恐惧修省。";
            TuanCi = "《彖》曰：震，亨。“震来虩虩”，恐致福也。“笑言哑哑”，后有则也。“震惊百里”，惊远而惧迩也。“不丧匕鬯”，出可以守宗庙社稷，以为祭主也。";
            YaoCi = new string[]
            {
                "初九，震来虩虩，后笑言哑哑，吉。",
                "六二，震来厉，亿丧贝，跻于九陵，勿逐，七日得。",
                "六三，震苏苏，震行无眚。",
                "九四，震遂泥。",
                "六五，震往来，厉，意无丧，有事。",
                "上六，震索索，视矍矍，征凶。震不于其躬，于其邻，无咎。婚媾有言。"

            };
            XiangCi = new string[]
            {
                "《象》曰：“震来虩虩”，恐致福也。“笑言哑哑”，后有则也。",
                "《象》曰：“震来厉”，乘刚也。",
                "《象》曰：“震苏苏”，位不当也。",
                "《象》曰：“震遂泥”，未光也。",
                "《象》曰：“震往来厉”，危行也。其事在中，大无丧也。",
                "《象》曰：“震索索”，中未得也。虽凶无咎，畏邻戒也。"

            };

        }
    }
}
