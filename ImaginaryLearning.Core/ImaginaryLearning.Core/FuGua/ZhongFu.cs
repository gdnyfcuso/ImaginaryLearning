using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 风泽中孚
    /// </summary>
    class ZhongFu : FuGua
    {
        public ZhongFu(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Xun(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Dui(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            Name = "中孚";
            PinYin = "ZhongFu";
            XuGua = 61;
            GuaCi = "豚鱼，吉。利涉大川，利贞。";
            GuaXiangCi = "《象》曰：泽上有风，中孚。君子以议狱缓死。";
            TuanCi = "《彖》曰：“中孚”，柔在内而刚得中，说而巽，孚乃化邦也。“豚鱼吉”，信及豚鱼也。“利涉大川”，乘木舟虚也。中孚以利贞，乃应乎天也。";
            YaoCi = new string[]
            {
                "初九，虞吉，有它不燕。",
                "九二，鸣鹤在阴，其子和之。我有好爵，吾与尔靡之。",
                "六三，得敌，或鼓或罢，或泣或歌。",
                "六四，月几望，马匹亡，无咎。",
                "九五，有孚挛如，无咎。",
                "上九，翰音登于天，贞凶。"
            };
            XiangCi = new string[]
            {
                "《象》曰：初九“虞吉”，志未变也。",
                "《象》曰：“其子和之”，中心愿也。",
                "《象》,曰：“或鼓或罢”，位不当也。",
                "《象》曰：“马匹亡”，绝类上也。",
                "《象》曰：“有孚挛如”，位正当也。",
                "《象》曰：“翰音登于天”，何可长也？"
            };
        }
    }
}
