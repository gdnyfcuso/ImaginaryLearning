using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 否卦，天在下，地在上
    /// </summary>
    public class PI : FuGua
    {
        public PI(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {

        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            XiaGua = new Kun(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            ShangGua = new Qian(startPoint, totalWidth, heigth);
            Name = "否";
            PinYin = "Pi";
            IsTwelvePIGua = true;
            XuGua = 12;
            GuaCi = "否之匪人，不利君子贞，大往小来。";
            TuanCi = "《彖》曰：“否之匪人，不利君子贞，大往小来。”则是天地不交而万物不通也，上下不交而天下无邦也；内阴而外阳，内柔而外刚，内小人而外君子，小人道长，君子道消也。";
            GuaXiangCi = "《象》曰：天地不交，“否”。君子以俭德辟难，不可荣以禄。";
            YaoCi = new string[]
            {
                "初六，拔茅茹以其汇。贞吉，亨。",
                "六二，包承，小人吉，大人否。亨。",
                "六三，包羞。",
                "九四，有命，无咎，畴离祉。",
                "九五，休否，大人吉。其亡其亡，系于苞桑。",
                "上九，倾否，先否后喜。"
            };
            XiangCi = new string[]
            {
                "《象》曰：“拔茅贞吉”，志在君也。",
                "《象》曰：“大人否亨”，不乱群也。",
                "《象》曰：“包羞”，位不当也。",
                "《象》曰：“有命无咎”，志行也。",
                "《象》曰：大人之吉，位正当也。",
                "《象》曰：否终则倾，何可长也。"
            };
        }
    }
}