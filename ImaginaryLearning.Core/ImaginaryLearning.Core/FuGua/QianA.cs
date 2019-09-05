using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 谦 地山谦
    /// </summary>
    public class QianA : FuGua
    {
        public QianA(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            Name = "DaYou";
            ShangGua = new Kun(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Gen(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            XuGua = 15;
            GuaCi = "《谦》：亨。君子有终。";
            TuanCi = "《彖》曰：谦，亨。天道下济而光明，地道卑而上行。天道亏盈而益谦，地道变盈而流谦，鬼神害盈而福谦，人道恶盈而好谦。谦，尊而光，卑而不可逾，君子之终也。";
            GuaXiangCi = "《象》曰：地中有山，谦。君子以裒多益寡，称物平施。";
            YaoCi = new string[]
            {
                "初六，谦谦君子，用涉大川，吉。",
                "六二，鸣谦，贞吉。",
                "九三，劳谦君子，有终，吉。",
                "六四，无不利，捴谦。",
                "六五，不富以其邻，利用侵伐，无不利。",
                "上六，鸣谦，利用行师征邑国。"
            };
            XiangCi = new string[]
            {
                "《象》曰：“谦谦君子”，卑以自牧也。",
                "《象》曰：“鸣谦贞吉”，中心得也。",
                "《象》曰：“劳谦君子”，万民服也。",
                "《象》曰：“无不利，捴谦”，不违则也。",
                "《象》曰：“利用侵伐”，征不服也。",
                "《象》曰：“鸣谦”，志未得也。“可用行师”，征邑国也。"
            };
        }
    }
}
