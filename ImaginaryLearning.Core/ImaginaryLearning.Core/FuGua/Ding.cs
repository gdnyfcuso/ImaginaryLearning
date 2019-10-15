using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 火风鼎
    /// </summary>
    public class Ding : FuGua
    {
        public Ding(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Li(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Xun(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            Name = "鼎";
            PinYin = "Ding";
            XuGua = 50;
            GuaCi = "元吉，亨。";
            TuanCi = "《彖》曰：鼎，象也。以木巽火，亨饪也。圣人亨以享上帝，而大亨以养圣贤。巽而耳目聪明，柔进而上行，得中而应乎刚，是以元亨。";
            GuaXiangCi = "《象》曰：木上有火，鼎。君子以正位凝命。";
            YaoCi = new string[]
            {
                "初六，鼎颠趾，利出否。得妾以其子，无咎。",
                "九二，鼎有实，我仇有疾，不我能即，吉。",
                "九三，鼎耳革，其行塞，雉膏不食，方雨，亏悔，终吉。",
                "九四，鼎折足，覆公餗，其形渥，凶。",
                "六五，鼎黄耳金铉，利贞。",
                "上九，鼎玉铉，大吉，无不利。"

            };
            XiangCi = new string[]
            {
                "《象》曰：“鼎颠趾”，未悖也。“利出否”，以従贵也。",
                "《象》曰：“鼎有实”，慎所之也。“我仇有疾”，终无尤也。",
                "《象》曰：“鼎耳革”，失其义也。",
                "《象》曰：“覆公餗”，信如何也。",
                "《象》曰：“鼎黄耳”，中以为实也。",
                "《象》曰：玉铉在上，刚柔节也。"
            };
        }
    }
}
