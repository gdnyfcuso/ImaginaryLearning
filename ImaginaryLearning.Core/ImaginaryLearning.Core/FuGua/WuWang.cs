using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    public class WuWang : FuGua
    {
        public WuWang(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Qian(startPoint, totalWidth, heigth);
            XiaGua = new Zhen(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            Name = "无妄";
            PinYin = "WuWang";
            XuGua = 26;
            GuaCi = "元亨，利贞。其匪正有眚，不利有攸往。"; ;
            TuanCi = "《彖》曰：无妄，刚自外来而为主于内，动而健，刚中而应。大亨以正，天之命也。“其匪正有眚，不利有攸往”，无妄之往何之矣？天命不祐，行矣哉！";
            GuaXiangCi = "《象》曰：天下雷行，物与无妄。先王以茂对时育万物。";
            YaoCi = new string[]
            {
                "初九，无妄往，吉。",
                "六二，不耕获，不菑畬，则利用攸往。",
                "六三，无妄之灾，或系之牛，行人之得，邑人之灾。",
                "九四，可贞。无咎。",
                "九五，无妄之疾，勿药有喜。",
                "上九，无妄行，有眚，无攸利。"
            };
            XiangCi = new string[]
            {
                "《象》曰：“无妄之往”，得志也。",
                "《象》曰：“不耕获”，未富也。",
                "《象》曰：行人得牛，邑人灾也。",
                "《象》曰：“可贞无咎”，固有之也。",
                "《象》曰：“无妄之药”，不可试也。",
                "《象》曰：“无妄之行”，穷之灾也。"
            };

        }
    }
}
