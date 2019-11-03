using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 雷山小过
    /// </summary>
    public class XiaoGuo : FuGua
    {
        public XiaoGuo(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Zhen(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Gen(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            Name = "小过";
            PinYin = "XiaoGuo";
            XuGua = 62;
            GuaCi = "亨。利贞。可小事，不可大事。飞鸟遗之音，不宜上，宜下，大吉。";
            GuaXiangCi = "《象》曰：山上有雷，小过。君子以行过乎恭，丧过乎哀，用过乎俭。";
            TuanCi = "《彖》曰：小过，小者过而亨也。过以利贞，与时行也。柔得中，是以小事吉也。刚失位而不中，是以不可大事也。有飞鸟之象焉，“飞鸟遗之音，不宜上，宜下，大吉”，上逆而下顺也。";
            YaoCi = new string[]
            {
                "初六，飞鸟以凶。",
                "六二，过其祖，遇其妣。不及其君，遇其臣。无咎。",
                "九三，弗过防之，従或戕之，凶。",
                "九四，无咎。弗过遇之，往厉必戒，勿用永贞。",
                "六五，密云不雨，自我西郊。公弋取彼在穴。",
                "上六，弗遇过之，飞鸟离之，凶，是谓灾眚。"
            };
            XiangCi = new string[]
            {
                "《象》曰：“飞鸟以凶”，不可如何也。",
                "《象》曰：“不及其君”，臣不可过也。",
                "《象》曰：“従或戕之”，凶如何也？斋",
                "《象》曰：“弗过遇之”，位不当也。“往厉必戒”，终不可长也。",
                "《象》曰：“密云不雨”，已上也。",
                "《象》曰：“弗遇过之”，已亢也。"
            };

        }
    }
}
