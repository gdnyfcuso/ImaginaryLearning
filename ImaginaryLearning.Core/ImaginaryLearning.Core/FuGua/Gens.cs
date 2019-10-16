using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 艮
    /// </summary>
    public class Gens : FuGua
    {
        public Gens(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Gen(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Gen(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            XuGua = 52;
            Name = "艮";
            PinYin = "Gen";
            GuaCi = "艮其背，不获其身，行其庭，不见其人，无咎。";
            TuanCi = "《彖》曰：艮，止也。时止则止，时行则行，动静不失其时，其道光明。“艮其止”，止其所也。上下敌应，不相与也。是以“不获其身，行其庭，不见其人，无咎”也。";
            GuaXiangCi = "《象》曰：兼山，艮。君子以思不出其位。";
            YaoCi = new string[]
            {
                "初六，艮其趾，无咎。利永贞。",
                "六二，艮其腓，不拯其随，其心不快。",
                "九三，艮其限，列其夤，厉，熏心。",
                "六四，艮其身，无咎。",
                "六五，艮其辅，言有序，悔亡。",
                "上九，敦艮，吉。"
            };
            XiangCi = new string[]
            {
                "《象》曰：“艮其趾”，未失正也。",
                "《象》曰：“不拯其随”，未退听也。",
                "《象》曰：“艮其限”，危熏心也。",
                "《象》曰：“艮其身”，止诸躬也。",
                "《象》曰：“艮其辅”，以中正也。",
                "《象》曰：“敦艮之吉”，以厚终也。"
            };
        }
    }
}
