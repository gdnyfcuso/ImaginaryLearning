using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 兑
    /// </summary>
    public class DuiA : FuGua
    {
        public DuiA(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Dui(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Dui(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            Name = "兑";
            PinYin = "Dui";
            XuGua = 58;
            IsTwelvePIGua = true;
            GuaCi = "亨。利贞。";
            GuaXiangCi = "《象》曰：丽泽，兑。君子以朋友讲习。";
            TuanCi = "《彖》曰：兑，说也。刚中而柔外，说以利贞，是以顺乎天而应乎人。说以先民，民忘其劳。说以犯难，民忘其死。说之大，民劝矣哉！";
            YaoCi = new string[]
            {
                "初九，和兑，吉。",
                "九二，孚兑，吉，悔亡。",
                "六三，来兑，凶。",
                "九四，商兑未宁，介疾有喜。",
                "九五，孚于剥，有厉。",
                "上六，引兑。"
            };
            XiangCi = new string[]
            {
                "《象》曰：“和兑之吉”，行未疑也。",
                "《象》曰：“孚兑之吉”，信志也。",
                "《象》曰：“来兑之凶”，位不当也。",
                "《象》曰：“九四之喜”，有庆也。",
                "《象》曰：“孚于剥”，位正当也。",
                "《象》曰：上六“引兑”，未光也。"
            };
        }
    }
}