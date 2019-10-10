using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 地风升
    /// </summary>
    public class Sheng : FuGua
    {
        public Sheng(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua=new Kun(startPoint,totalWidth,midWidth,heigth);
            XiaGua = new Xun(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            Name = "升";
            PinYin = "Sheng";
            XuGua = 46;
            GuaCi = "元亨。用见大人，勿恤。南征吉。";
            TuanCi = "《彖》曰：柔以时升，巽而顺，刚中而应，是以大亨，“用见大人勿恤”，有庆也。“南征吉”，志行也。";
            GuaXiangCi = "《象》曰：地中生木，升。君子以顺德，积小以高大。";
            YaoCi = new string[]
            {
                "初六，允升，大吉。",
                "九二，孚乃利用禴，无咎。",
                "九三，升虚邑。",
                "六四，王用亨于岐山，吉，无咎。",
                "六五，贞吉，升阶。",
                "上六，冥升，利于不息之贞。"

            };
            XiangCi = new string[]
            {
                "《象》曰：“允升大吉”，上合志也。",
                "《象》曰：九二之孚，有喜也。",
                "《象》曰：“升虚邑”，无所疑也。",
                "《象》曰：“王用亨于岐山”，顺事也。",
                "《象》曰：“贞吉升阶”，大得志也。",
                "《象》曰：冥升在上，消不富也。"
            };
        }
    }
}
