using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 泽雷随
    /// </summary>
    public class Sui : FuGua
    {
        public Sui(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Dui(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Zhen(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            Name = "随";
            XuGua = 17;
            PinYin = "Sui";
            GuaCi = "元亨，利贞，无咎。";
            TuanCi = " 《彖》曰：随，刚来而下柔，动而说，随。大亨贞无咎，而天下随时，随时之义大矣哉！";
            GuaXiangCi = "《象》曰：泽中有雷，随。君子以向晦入宴息。";
            YaoCi = new string[]
            {
                "初九，官有渝，贞吉，出门交有功。",
                "六二，系小子，失丈夫。",
                "六三，系丈夫，失小子，随有求，得。利居贞。",
                "九四，随有获，贞凶。有孚在道，以明，何咎？",
                "九五，孚于嘉，吉。",
                "上六，拘系之，乃従维之，王用亨于西山。"

            };

            XiangCi = new string[] {

                "《象》曰：“官有渝”，従正吉也。“出门交有功”，不失也。",
                "《象》曰：“系小子”，弗兼与也。",
                "《象》曰：“系丈夫”，志舍下也。",
                "《象》曰：“随有获”，其义凶也。“有孚在道”，明功也。",
                "《象》曰：“孚于嘉吉”，位正中也。",
                "《象》日：拘系之，上穷也"
            };
        }
    }
}
