using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 既济水火
    /// </summary>
    public class JIJI : FuGua
    {
        public JIJI(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Kan(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Li(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            Name = "既济";
            PinYin = "Jiji";
            XuGua = 63;
            GuaCi = "亨小，利贞。初吉终乱。";
            GuaXiangCi = "《象》曰：水在火上，既济。君子以思患而豫防之。";
            TuanCi = "《彖》曰：“既济，亨”，小者亨也。“利贞”。刚柔正而位当也。“初吉”，柔得中也。“终止则乱”，其道穷也。";
            YaoCi = new string[]
            {
                "初九，曳其轮，濡其尾，无咎。",
                "六二，“妇丧其茀，勿逐，七日得。",
                "九三，高宗伐鬼方，三年克之，小人勿用。",
                "六四，繻有衣袽，终日戒。",
                "九五，东邻杀牛，不如西邻之禴祭，实受其福。",
                "上六，濡其首，厉。"
            };
            XiangCi = new string[]
            {
                "《象》曰：“曳其轮”，义无咎也。",
                "《象》曰：“七日得”，以中道也。",
                "《象》曰：“三年克之”，惫也。",
                "《象》曰：“终日戒”，有所疑也。",
                "《象》曰：“东邻杀牛”，不如西邻之时也。“实受其福”，吉大来也。",
                "《象》曰：“濡其首厉”，何可久也？"
            };
        }
    }
}
