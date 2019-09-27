using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    public class Yi : FuGua
    {
        public Yi(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Gen(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Zhen(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            Name = "颐";
            PinYin = "Yi";
            XuGua = 33;
            GuaCi = "贞吉。观颐，自求口实。";
            TuanCi = "《彖》曰：颐，贞吉，养正则吉也。观颐，观其所养也。自求口实，观其自养也。天地养万物，圣人养贤以及万民，颐之时大矣哉！";
            GuaXiangCi = "《象》曰：山下有雷，颐。君子以慎言语，节饮食。";
            YaoCi = new string[]
            {
                "初九，舍尔灵龟，观我朵颐，凶。",
                "六二，颠颐拂经于丘颐，征凶。",
                "六三，拂颐，贞凶，十年勿用，无攸利。",
                "六四，颠颐，吉。虎视眈眈，其欲逐逐，无咎。",
                "六五，拂经，居贞吉，不可涉大川。",
                "上九，由颐，厉，吉。利涉大川。"
            };

            XiangCi = new string[]
            {
                "《象》曰：“观我朵颐”，亦不足贵也。",
                "《象》曰：“六二征凶”，行失类也。",
                "《象》曰：“十年勿用”，道大悖也。",
                "《象》曰：“颠颐之吉”，上施光也。",
                "《象》曰：“居贞之吉”，顺以従上也。",
                "《象》曰：“由颐厉吉”，大有庆也。"
            };
            
        }
    }
}
