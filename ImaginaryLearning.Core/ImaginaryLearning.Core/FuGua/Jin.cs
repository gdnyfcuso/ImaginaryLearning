using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 为地晋
    /// </summary>
    public class Jin : FuGua
    {
        public Jin(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Li(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Kun(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            Name = "晋";
            XuGua = 37;
            PinYin = "Jin";
            GuaCi = "康侯用锡马蕃庶，昼日三接。";
            TuanCi = "《彖》曰：晋，进也，明出地上。顺而丽乎大明，柔进而上行，是以“康侯用锡马蕃庶，昼日三接”也。";
            GuaXiangCi = "《象》曰：明出地上，《晋》。君子以自昭明德。";
            YaoCi = new string[]
            {
                "初六，晋如摧如，贞吉。罔孚，裕无咎。",
                "六二，晋如，愁如，贞吉。受兹介福于，其王母。",
                "六三，众允，悔亡。",
                " 九四，晋如鼫鼠，贞厉。",
                "六五，悔亡，失得，勿恤。往吉，无不利。",
                "上九，晋其角，维用伐邑，厉吉，无咎，贞吝。"
            };
            XiangCi = new string[]
            {
                "《象》曰：“晋如摧如”，独行正也。“裕无咎”。未受命也。",
                "《象》曰：“受兹介福”，以中正也。",
                "《象》曰：“众允”之志，上行也。",
                "《象》曰：“鼫鼠贞厉”，位不当也。",
                "《象》曰：“失得勿恤”，往有庆也。",
                "《象》曰：“维用伐邑”，道未光也。"
            };
        }
    }
}
