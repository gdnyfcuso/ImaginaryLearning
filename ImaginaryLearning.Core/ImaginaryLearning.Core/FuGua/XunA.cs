using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 巽
    /// </summary>
    public class XunA : FuGua
    {
        public XunA(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Xun(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Xun(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            Name = "巽";
            PinYin = "Xun";
            XuGua = 57;
            GuaCi = "小亨。利有攸往。利见大人。";
            GuaXiangCi = "《象》曰：随风，巽。君子以申命行事。";
            TuanCi = "《彖》曰：重巽以申命。刚巽乎中正而志行。柔皆顺乎刚，是以“小亨，利有攸往，利见大人”。";
            YaoCi = new string[]
            {
                "初六，进退，利武人之贞。",
                "九二，巽在床下，用史巫纷若，吉，无咎。",
                "九三，频巽，吝。",
                "六四，悔亡，田获三品。",
                "九五，贞吉，悔亡，无不利，无初有终。先庚三日，后庚三日，吉。",
                "上九，巽在床下，丧其资斧，贞凶。"
            };
            XiangCi = new string[] {
                "《象》曰：“进退”，志疑也。“利武人之贞”，志治也。",
                "《象》曰：“纷若之吉”，得中也。",
                "《象》曰：“频巽之吝”，志穷也。",
                "《象》曰：“田获三品”，有功也。",
                "《象》曰：九五之吉，位正中也。",
                "《象》曰：“巽在床下”，上穷也。“丧其资斧”，正乎凶也。"
            };
        }
    }
}
