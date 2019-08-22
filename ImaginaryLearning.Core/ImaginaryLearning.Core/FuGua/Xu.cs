using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    ///水天需 坎上乾下
    /// </summary>
    public class Xu : FuGua
    {
        public Xu(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Kan(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Qian(CreateXiaGuaPoint(startPoint, heigth), totalWidth, heigth);
            Name = "需";
            PinYin = "Xu";
            XuGua = 5;
            GuaCi = "有孚，光亨。贞吉，利涉大川。";
            TuanCi = "《彖》曰：“需”，须也。险在前也，刚健而不陷，其义不困穷矣。" +
                "“需，有孚，光亨，贞吉”，位乎天位，以正中也。“利涉大川”，往有功也。";
            GuaXiangCi = "《象》曰：云上于天，需。君子以饮食宴乐。";
            YaoCi = new string[]
            {
                "初九，需于郊，利用恒，无咎。",
                "九二，需于沙，小有言，终吉。",
                "九三，需于泥，致寇至。",
                "六四，需于血，出自穴。",
                "九五，需于酒食，贞吉。",
                "上六，入于穴，有不速之客三人来，敬之终吉。"
            };

            XiangCi = new string[]
            {
                " 《象》曰：“需于郊”，不犯难行也。“利用恒无咎”，未失常也。",
                "《象》曰：“需于沙”，衍在中也。虽小有言，以终吉也。",
                "《象》曰：“需于泥”，灾在外也。自我致寇，敬慎不败也。",
                "《象》曰：“需于血，”顺以听也。",
                "《象》曰：“酒食贞吉”，以中正也。",
                "《象》曰：“不速之客来，敬之终吉”，虽不当位，未大失也。"
            };
        }
    }
}
