using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 风水涣
    /// </summary>
    public class Huan : FuGua
    {
        public Huan(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Xun(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Kan(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            Name = "涣";
            PinYin = "Huan";
            XuGua = 59;
            GuaCi = "亨。王假有庙。利涉大川，利贞。";
            GuaXiangCi = "《象》曰：风行水上，涣。先王以享于帝，立庙。";
            TuanCi = "《彖》曰：“涣，亨”，刚来而不穷，柔得位乎外而上同。“王假有庙”，王乃在中也。“利涉大川”，乘木有功也。";
            YaoCi = new string[]
            {
                "初六，用拯马壮，吉。",
                "九二，涣奔其机，悔亡。",
                "六三，涣其躬，无悔。",
                "六四，涣其群，元吉。涣有丘，匪夷所思。",
                "九五，涣汗其大号，涣王居，无咎。",
                "上九，涣其血，去逖出，无咎。"
            };
            XiangCi = new string[]
            {
                "《象》曰：初六之吉顺也。",
                "《象》曰：“涣奔其机”，得愿也。",
                "《象》曰：“涣其躬”，志在外也。",
                "《象》曰：“涣其群元吉”，光大也。",
                "《象》曰：“王居无咎”，正位也。",
                "《象》曰：“涣其血”，远害也。"
            };
        }
    }
}
