using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 火山旅
    /// </summary>
    public class LVA : FuGua
    {
        public LVA(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Li(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Gen(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            Name = "旅";
            PinYin = "Lv";
            GuaCi = "小亨。旅贞吉。";
            TuanCi = "《彖》曰：“旅小亨”，柔得中乎外，而顺乎刚，止而丽乎明，是以“小亨旅贞吉”也。旅之时义大矣哉！";
            GuaXiangCi = "《象》曰：山上有火，旅。君子以明慎用刑而不留狱。";
            XuGua = 56;
            YaoCi = new string[]
            {
                "初六，旅琐琐，斯其所取灾。",
                "六二，旅即次，怀其资，得童仆，贞。",
                "九三，旅焚其次，丧其童仆，贞厉。",
                "九四，旅于处，得其资斧，我心不快。",
                "六五，射雉，一矢亡，终以誉命。",
                "上九，鸟焚其巢，旅人先笑后号咷。丧牛于易，凶。"
            };
            XiangCi = new string[]
            {
                "《象》曰：“旅琐琐”，志穷灾也。",
                "《象》曰：“得童仆贞”，终无尤也。",
                "《象》曰：“旅焚其次”，亦以伤矣。以旅与下，其义丧也。",
                "《象》曰：“旅于处”，未得位也。“得其资斧”，心未快也。",
                "《象》曰：“终以誉命”，上逮也。",
                "《象》曰：以旅在上，其义焚也。“丧牛于易”，终莫之闻也。"
            };
        }
    }
}
