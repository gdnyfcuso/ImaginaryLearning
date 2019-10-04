using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 火泽睽
    /// </summary>
    public class Kui : FuGua
    {
        public Kui(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Li(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Dui(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            Name = "睽";
            PinYin = "Kui";
            XuGua = 38;
            GuaCi = "小事吉。";
            TuanCi = " 《彖》曰：睽，火动而上，泽动而下。二女同居，其志不同行。说而丽乎明，柔进而上行，得中而应乎刚，是以小事吉。天地睽而其事同也。男女睽而其志通也。万物睽而其事类也，睽之时用大矣哉!";
            GuaXiangCi = "《象》曰：上火下泽，睽。君子以同而异。";
            YaoCi = new string[]
            {
                "初九，悔亡。丧马勿逐自复。见恶人无咎。",
                "九二，遇主于巷，无咎。",
                "六三，见舆曳，其牛掣，其人天且劓，无初有终。",
                "九四，睽孤遇元夫，交孚，厉，无咎。",
                "六五，悔亡。厥宗噬肤，往何咎？斋",
                "上九，睽孤见豕负涂，载鬼一车，先张之弧，后说之弧，匪寇，婚媾。往遇雨则吉。"
            };
            XiangCi = new string[]
            {
                "《象》曰：“见恶人”，以辟咎也。",
                "《象》曰：“遇主于巷”，未失道也。",
                "《象》曰：“见舆曳”，位不当也。“无初有终”，遇刚也。",
                "《象》曰：“交孚无咎”，志行也。",
                "《象》曰：“厥宗噬肤”，往有庆也。",
                "《象》曰：“遇雨之吉”，群疑亡也。"
            };

        }
    }
}
