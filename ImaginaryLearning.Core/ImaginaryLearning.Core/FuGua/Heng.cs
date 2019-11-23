using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    public class Heng : FuGua
    {
        public Heng(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Zhen(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Xun(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            Name = "恒";
            XuGua = 32;
            PinYin = "Heng";
            GuaCi = "亨。无咎。利贞。利有攸往。";
            TuanCi = " 《彖》曰：恒，久也。刚上而柔下。雷风相与，巽而动，刚柔皆应，恒。“恒亨无咎利贞”，久于其道也。天地之道恒久而不已也。“利有攸往”，终则有始也。日月得天而能久照，四时变化而能久成。圣人久于其道而天下化成。观其所恒，而天地万物之情可见矣。";
            GuaXiangCi = "《象》曰：雷风，恒。君子以立不易方。";
            YaoCi = new string[]
            {
                " 初六，浚恒，贞凶，无攸利。",
                "九二，悔亡。",
                "九三，不恒其德，或承之羞，贞吝。",
                "九四，田无禽。",
                "六五，恒其德，贞，妇人吉，夫子凶。",
                "上六，振恒，凶。"
            };
            XiangCi = new string[]
            {
                "《《象》曰：“浚恒”之“凶”，始求深也。",
                "《象》曰：九二“悔亡”，能久中也。",
                "《象》曰：“不恒其德”，无所容也。",
                "《象》曰：久非其位，安得禽也。",
                "《象》曰：妇人贞吉，従一而终也。夫子制义，従妇凶也。",
                "《象》曰：振恒在上，大无功也。"
            };
        }
    }
}