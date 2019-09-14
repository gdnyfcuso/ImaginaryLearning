using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    public class BiA : FuGua
    {
        public BiA(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Gen(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Li(CreateXiaGuaPoint(startPoint,heigth), totalWidth, midWidth, heigth);
            Name = "贲";
            PinYin = "Bi";
            XuGua = 21;
            GuaCi = "亨。小利有攸往。";
            GuaXiangCi = "《象》曰：山下有火，贲。君子以明庶政，无敢折狱。";
            TuanCi = "《彖》曰：贲亨，柔来而文刚，故亨。分，刚上而文柔，故小利有攸往。刚柔交错，天文也。文明以止，人文也。观乎天文，以察时变；观乎人文，以化成天下。";
            YaoCi = new string[]
            {
                "初九，贲其趾，舍车而徒。",
                "六二，贲其须。",
                "九三，贲如，濡如，永贞吉。",
                "六四，贲如皤如，白马翰如。匪寇，婚媾。",
                "六五，贲于丘园，束帛戋戋，吝，终吉。",
                "上九，白贲，无咎。",
            };
            XiangCi = new string[]
            {
                "《象》曰：“舍车而徒”，义弗乘也。",
                "《象》曰：“贲其须”，与上兴也。",
                "《象》曰：“永贞之吉”，终莫之陵也。",
                "《象》曰：六四，当位疑也。“匪寇婚媾”，终无尤也。",
                "《象》曰：“六五之吉”，有喜也。",
                "《象》曰：“白贲无咎”，上得志也。"
            };
        }
    }
}
