using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 天山遁
    /// </summary>
    public class Dun : FuGua
    {
        public Dun(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Qian(startPoint, totalWidth, heigth);
            XiaGua = new Gen(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            Name = "遁";
            PinYin = "Dun";
            XuGua = 35;
            GuaCi = "亨。小利贞。";
            TuanCi = "《彖》曰：“遁亨”，遁而亨也。刚当位而应，与时行也。“小利贞”，浸而长也。遁之时义大矣哉！斋";
            GuaXiangCi = "《象》曰：天下有山，遁。君子以远小人，不恶而严。";
            YaoCi = new string[]
            {
                "初六，遁尾，厉，勿用有攸往。",
                "六二，执之用黄牛之革，莫之胜说。",
                "九三，系遁，有疾厉，畜臣妾吉。",
                "九四，好遁，君子吉，小人否。",
                "九五，嘉遁，贞吉。",
                "上九，肥遁，无不利。"
            };
            XiangCi = new string[]
            {
                "《象》曰：“遁尾”之“厉”，不往何灾也？古",
                "《象》曰：“执用黄牛”，固志也。",
                "《象》曰：“系遁”之“厉”，有疾惫也。“畜臣妾吉”，不可大事也。",
                "《象》曰：“君子好遁，小人否”也。",
                "《象》曰：“嘉遁贞吉”，以正志也",
                "《象》曰：“肥遁无不利”，无所疑也。"
            };

        }
    }
}
