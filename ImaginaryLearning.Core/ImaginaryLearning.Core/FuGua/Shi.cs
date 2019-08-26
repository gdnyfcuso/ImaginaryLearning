using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 坤为地，坎为水，地中有水。
    /// 地中众者，莫过于水。
    /// 师为众，部属兵士众多的意思。
    /// 持正的“仁义之师”，才可攻伐天下使百姓服从，用兵胜负在于择将选帅，持重老成的人统兵可获吉祥，这样才没有灾祸。
    /// </summary>
    public class Shi : FuGua
    {
        public Shi(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            XiaGua = new Kan(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            ShangGua = new Kun(startPoint, totalWidth, midWidth, heigth);
            Name = "师";
            PinYin = "Shi";
            XuGua = 7;
            GuaCi = "贞丈人吉，无咎。";
            TuanCi = "《彖》曰：师，众也。贞，正也。能以众正，可以王矣。刚中而应，行险而顺，以此毒天下，而民従之，吉又何咎矣。";
            GuaXiangCi = "《象》曰：地中有水，师。君子以容民畜众。";
            YaoCi = new string[]
            {
                "初六，师出以律，否臧凶。",
                "九二，在师中吉，无咎，王三锡命。",
                "六三，师或舆尸，凶。",
                "六四，师左次，无咎。",
                "六五，田有禽。利执言，无咎。长子帅师，弟子舆尸，贞凶。",
                "上六，大君有命，开国承家，小人勿用。"
            };
            XiangCi = new string[]
            {
                "《象》曰：“师出以律，”失律凶也。",
                "《象》曰：“在师中吉”，承天宠也。“王三锡命”，怀万邦也。",
                "《象》曰：“师或舆尸”，大无功也。",
                "《象》曰：“左次无咎”，未失常也。",
                "《象》曰：“长子帅师”，以中行也。“弟子舆尸”，使不当也。",
                "《象》曰：“大君有命”，以正功也。“小人勿用”，必乱邦也。"
            };
        }
    }
}