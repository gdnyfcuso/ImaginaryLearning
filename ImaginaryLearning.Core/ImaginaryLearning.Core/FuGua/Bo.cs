
using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 山地剥
    /// </summary>
    public class Bo : FuGua
    {
        public Bo(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Gen(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Kun(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            Name = "剥";
            XuGua = 23;
            PinYin = "Bo";
            GuaCi = "不利有攸往。";
            TuanCi = "《彖》曰：剥，剥也。柔变刚也。“不利有攸往”，小人长也。顺而止之，观象也。君子尚消息盈虚，天行也。";
            GuaXiangCi = "《象》曰：山附于地，剥。上以厚下安宅。";
            YaoCi = new string[]
            {
                "初六：剥床以足，蔑贞凶。",
                "六二：剥床以辨，蔑贞凶。",
                "六三：剥之，无咎。",
                "六四：剥床以肤，凶。",
                "六五：贯鱼以宫人宠，无不利。",
                "上九：硕果不食，君子得舆，小人剥庐。"
            };
            XiangCi = new string[]
            {
                "《象》曰：“剥床以足”，以灭下也。",
                "《象》曰：“剥床以辨”，未有与也。",
                "《象》曰：“剥之无咎”，失上下也。",
                "《象》曰：“剥床以肤”，切近灾也。",
                "《象》曰：“以宫人宠”，终无尤也。",
                "《象》曰：“君子得舆”，民所载也。“小人剥庐”，终不可用也。"
            };
        }
    }
}
