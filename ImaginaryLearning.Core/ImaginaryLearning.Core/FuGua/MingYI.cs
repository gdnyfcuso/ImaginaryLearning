using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    public class MingYI : FuGua
    {
        public MingYI(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Kun(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Li(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            Name = "明夷";
            PinYin = "MingYi";
            XuGua = 38;
            GuaCi = "利艰贞。";
            TuanCi = "《彖》曰：明入地中，“明夷”。内文明而外柔顺，以蒙大难，文王以之。“利艰贞”，晦其明也，内难而能正其志，箕子以之。";
            GuaXiangCi = "《象》曰：明入地中，“明夷”。君子以莅众用晦而明。";
            YaoCi = new string[]
            {
                "初九，明夷，于飞垂其翼。君子于行，三日不食。有攸往，主人有言。",
                " 六二，明夷夷于左股，用拯马壮，吉。",
                "九三，明夷于南狩，得其大首，不可疾贞。",
                "六四，入于左腹，获明夷之心，于出门庭。",
                "六五，箕子之明夷，利贞。",
                "上六，不明，晦，初登于天，后入于地。"
            };
            XiangCi = new string[]
            {
                "《象》曰：“君子于行”，义不食也。",
                "《象》曰：六二之吉，顺以则也。",
                "《象》曰：“南狩”之志，乃得大也。",
                "《象》曰：“入于左腹”，获心意也。",
                "《象》曰：箕子之贞，明不可息也。",
                "《象》曰：“初登于天”，照四国也。“后入天地”，失则也。"
            };
        }
    }
}
