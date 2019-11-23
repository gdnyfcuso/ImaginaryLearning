using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    public class DaGuo : FuGua
    {
        public DaGuo(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Dui(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Xun(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            Name = "大过";
            XuGua = 28;
            PinYin = "DaGuo";
            GuaCi = "栋挠，利有攸往，亨。";
            GuaXiangCi = "《象》曰：泽灭木，大过。君子以独立不惧，遯世无闷。";
            TuanCi = "《彖》曰：“大过”，大者过也。“栋挠”，本末弱也。刚过而中，巽而说，行。利有攸往，乃亨。“大过”之时大矣哉！";
            YaoCi = new string[]
            {
                " 初六，藉用白茅，无咎。",
                "九二，枯杨生稊，老夫得其女妻，无不利。",
                "九三，栋桡，凶。",
                "九四，栋隆，吉。有它，吝。",
                " 九五，枯杨生华，老妇得其士夫，无咎无誉。",
                "上六，过涉灭顶，凶。无咎。"
            };
            XiangCi = new string[]
            {
                "《象》曰：“藉用白茅”，柔在下也。",
                "《象》曰：“老夫女妻，”，过以相与也。",
                "《象》曰：“栋桡”之“凶”，不可以有辅也。",
                "《象》曰：“栋隆之吉”，不桡乎下也。",
                "《象》曰：“枯杨生华”，何可久也。“无妇士夫”，亦可丑也。",
                "《象》曰：“过涉之凶”，不可咎也。"
            };
        }
    }
}
