using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 节 水泽
    /// </summary>
    public class JieA : FuGua
    {
        public JieA(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Kan(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Dui(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            Name = "节";
            PinYin = "Jie";
            XuGua = 60;
            GuaCi = "亨。苦节，不可贞。";
            GuaXiangCi = "《象》曰：泽上有水，节。君子以制数度，议德行。";
            TuanCi = "《彖》曰：“节亨”。刚柔分而刚得中。“苦节不可贞”，其道穷也。说以行险，当位以节，中正以通。天地节而四时成。节以制度，不伤财，不害民。";
            YaoCi = new string[]
            {
                "初九，不出户庭，无咎。",
                "九二，不出门庭，凶。",
                "六三，不节若，则嗟若，无咎。",
                "六四，安节。亨。",
                "九五，甘节，吉，往有尚。",
                "上六，苦节，贞凶，悔亡。"

            };
            XiangCi = new string[]
            {
                "《象》曰：“不出户庭”，知通塞也。",
                "《象》曰：“不出门庭凶”，失时极也。",
                "《象》曰：“不节之嗟”，又谁咎也。",
                "《象》曰：“安节之亨”，承上道也。",
                "《象》曰：“甘节之吉”，居位中也。",
                "《象》曰：“苦节贞凶”，其道穷也。"
            };

        }
    }
}
