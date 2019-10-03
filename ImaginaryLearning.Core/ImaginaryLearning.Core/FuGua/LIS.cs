using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 离
    /// </summary>
    public class LIS : FuGua
    {
        public LIS(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Li(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Li(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);

            Name = "离";
            PinYin = "Li";
            XuGua = 32;
            GuaCi = "利贞。亨。畜牝牛吉。";
            TuanCi = "《彖》曰：离，丽也。日月丽乎天，百谷草木丽乎土。重明以丽乎正，乃化成天下。柔丽乎中正，故，是以“畜牝牛吉”也。";
            GuaXiangCi = "《象》曰：明两作，离。大人以继明照于四方。";
            YaoCi = new string[]
            {
                "初九，履错然，敬之无咎。",
                "六二，黄离，元吉。",
                "九三，日昃之离，不鼓缶而歌，则大耋之嗟，凶。",
                "九四，突如，其来如，焚如，死如，弃如。",
                "六五，出涕沱若，戚嗟若，吉。",
                "上九，王用出征，有嘉折首，获匪其丑，无咎。"
            };
            XiangCi = new string[]
            {
                "《象》曰：“履错之敬”，以辟咎也。",
                "《象》曰：“黄离元吉”，得中道也。",
                "《象》曰：“日昃之离”，何可久也？知",
                "《象》曰：“突如其来如”，无所容也。",
                "《象》曰：六五之吉，离王公也。",
                "《象》曰：“王用出征”，以正邦也。"
            };
            

        }
    }
}
