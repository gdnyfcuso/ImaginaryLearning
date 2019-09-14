using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 山风蛊
    /// </summary>
    public class Gu : FuGua
    {
        public Gu(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Gen(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Xun(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            Name = "蛊";
            PinYin = "Gu";
            XuGua = 18;
            GuaCi = "元亨。利涉大川，先甲三日，后甲三日。";
            TuanCi = "《彖》曰：蛊，刚上而柔下，巽而止，蛊。蛊，元亨而天下治也。“利涉大川”，往有事也。“先甲三日，后甲三日”，终则有始，天行也。";
            GuaXiangCi = "《象》曰：山下有风，蛊。君子以振民育德。";
            YaoCi = new string[]
            {
                "初六，干父之蛊，有子，考无咎。厉，终吉。",
                "九二，干母之蛊，不可贞。",
                "九三，干父之蛊，小有悔，无大咎。",
                "六四，裕父之蛊，往见吝。",
                "六五，干父之蛊，用誉。",
                "上九：不事王侯，高尚其事"
            };
            XiangCi = new string[]
            {
                "《象》曰：“干父之蛊”，意承考也。",
                "《象》曰：“干母之蛊”，得中道也。",
                "《象》曰：“干父之蛊”，终无咎也。",
                "《象》曰：“裕父之蛊”，往未得也。",
                "《象》曰：“干父用誉”，承以德也。",
                "《象》曰：“不事王侯”，志可则也。"
            };

        }
    }
}
