using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 风雷益
    /// </summary>
    public class YiA : FuGua
    {
        public YiA(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Xun(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Zhen(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            Name = "益";
            PinYin = "Yi";
            XuGua = 42;
            GuaCi = "利有攸往。利涉大川。";
            TuanCi = "《彖》曰：“益”，损上益下，民说无疆。自上下下，其道大光。“利有攸往”，中正有庆。“利涉大川”，木道乃行。益动而巽，日进无疆。天施地生，其益无方。凡益之道，与时偕行。";
            GuaXiangCi = "《象》曰：风雷，益。君子以见善则迁，有过则改。";
            YaoCi = new string[]
            {
                "初九，利用为大作，元吉，无咎。",
                "六二，或益之十朋之龟，弗克违。永贞吉。王用享于帝，吉。",
                "六三，益之用凶事，无咎。有孚。中行告公用圭。",
                "六四，中行告公，従，利用为依迁国。",
                " 九五，有孚惠心，勿问，元吉。有孚，惠我德。",
                "上九，莫益之，或击之，立心勿恒，凶。"
            };
            XiangCi = new string[]
            {
                "《象》曰：“元吉无咎”，下不厚事也。",
                "《象》曰：“或益之”，自外来也。",
                "《象》曰：“益用凶事”，固有之也。",
                "《象》曰：“告公従”，以益志也。",
                "《象》曰：“有孚惠心”，勿问之矣。“惠我德”，大得志也。",
                "《象》曰：“莫益之”，偏辞也。“或击之”，自外来也。"
            };
        }
    }
}
