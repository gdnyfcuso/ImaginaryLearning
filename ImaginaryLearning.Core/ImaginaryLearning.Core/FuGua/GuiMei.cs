using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 雷泽归妹
    /// </summary>
    public class GuiMei : FuGua
    {
        public GuiMei(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Zhen(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Dui(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            Name = "归妹";
            PinYin = "GuiMei";
            XuGua = 54;
            GuaCi = "征凶，无攸利。";
            GuaXiangCi = "《象》曰：泽上有雷，归妹。君子以永终知敝。";
            TuanCi = "《彖》曰：归妹，天地之大义也。天地不交而万物不兴。归妹，人之终始也。说以动，所归妹也。“征凶”，位不当也。“无攸利”，柔乘刚也。";
            YaoCi = new string[]
            {
                "初九，归妹以娣。跛能履，征吉。",
                "九二，眇能视，利幽人之贞。",
                "六三，归妹以须，反归以娣。",
                "九四，归妹愆期，迟归有时。",
                "六五，帝乙归妹，其君之袂不如其娣之袂良。月几望，吉。",
                "上六，女承筐无实，士刲羊无血，无攸利。"
            };
            XiangCi = new string[]
            {
                "《象》曰：“归妹以娣”，以恒也。“跛能履吉”，相承也。",
                "《象》曰：“利幽人之贞”，未变常也。",
                "《象》曰：“归妹以须”，未当也。",
                "《象》曰：“愆期”之志，有待而行也。",
                "《象》曰：“帝乙归妹，不如其娣之袂良”也。其位在中，以贵行也。",
                "《象》曰：上六无实，承虚筐也。"
            };

        }
    }
}
