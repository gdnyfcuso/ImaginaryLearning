using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 火天大有
    /// </summary>
    public class DaYou : FuGua
    {
        public DaYou(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            Name = "DaYou";
            ShangGua = new Li(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Qian(CreateXiaGuaPoint(startPoint, heigth), totalWidth, heigth);
            XuGua = 14;
            GuaCi = "《大有》：元亨。";
            TuanCi = "《彖》曰：“大有”，柔得尊位大中，而上下应之，曰“大有”。其德刚健而文明，应乎天而时行，是以元亨。";
            GuaXiangCi = "《象》曰：火在天上，“大有”。君子以遏恶扬善，顺天休命。";
            YaoCi = new string[]
            {
                "初九，无交害匪咎。艰则无咎。",
                "九二，大车以载，有攸往，无咎。",
                "九三，公用亨于天子，小人弗克。",
                "九四，匪其彭，无咎。",
                "六五，厥孚交如威如，吉。",
                "上九，自天祐之，吉，无不利。"
            };
            XiangCi = new string[]
            {
                "《象》曰：大有初九，无交害也。",
                "《象》曰：“大车以载”，积中不败也。",
                "《象》曰：公用亨于天子，小人害也。",
                "《象》曰：“匪其彭，无咎。”明辨晰也。",
                "《象》曰：“厥孚交如”，信以发志也。“威如之吉”，易而无备也。",
                "《象》曰：大有上吉，自天祐也。"
            };
        }
    }
}
