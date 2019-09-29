using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 山天
    /// </summary>
    public class DaXu : FuGua
    {
        public DaXu(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Gen(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Qian(CreateXiaGuaPoint(startPoint, heigth), totalWidth, heigth);
            Name = "大畜";
            PinYin = "DaXu";
            XuGua = 26;
            GuaCi = "利贞。不家食吉。利涉大川。";
            TuanCi = "《彖》曰：大畜，刚健笃实，辉光日新。其德刚上而尚贤，能止健，大正也。“不家食吉”，养贤也。“利涉大川”，应乎天也。";
            GuaXiangCi = "《象》曰：天在山中，大畜。君子以多识前贤往行，以畜其德。";
            YaoCi = new string[]
            {
                "初九，有厉，利已。",
                "九二，舆说輹。",
                "九三，良马逐，利艰贞，曰闲舆卫，利有攸往。",
                "六四，童牛之牿，元吉。",
                "六五，豮豕之牙，吉。",
                "上九，何天之衢，亨。"
            };

            XiangCi = new string[]
            {
                "《象》曰：“有厉利已”，不犯灾也。",
                "《象》曰：“舆说輹”，中无尤也。",
                "《象》曰：“利有攸往”，上合志也。",
                "《象》曰：“六四元吉”，有喜也。",
                "《象》曰：“六五之吉”，有庆也。",
                "《象》曰：“何天之衢”，道大行也。"
            };
        }
    }
}
