using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 屯卦
    /// 水雷屯
    /// </summary>
    public class Zhun : FuGua
    {
        public Zhun(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {

        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Kan(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Zhen(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            Name = "屯";
            PinYin = "Zhun";
            XuGua = 3;
            GuaCi = "元亨，利贞。勿用有攸往。利建侯。";
            TuanCi = "《彖》曰：屯，刚柔始交而难生。动乎险中，大亨贞。雷雨之动满盈，天造草昧。宜寻建侯而不宁。";
            GuaXiangCi = "《象》曰：云雷，屯。君子以经纶。";
            YaoCi = new string[] {
                "初九，磐桓，利居贞。利建侯。",
                "六二，屯如邅如，乘马班如。匪寇，婚媾。女子贞不字，十年乃字。",
                "六三，即鹿无虞，惟入于林中，君子几不如舍，往吝。",
                "六四，乘马班如，求婚媾。往吉，无不利。",
                "九五，屯其膏，小，贞吉；大，贞凶。",
                "上六，乘马班如，泣血涟如。"
            };
            XiangCi = new string[] {
                "《象》曰：虽磐桓，志行正也。以贵下贱，大得民也。",
                "《象》曰：六二之难，乘刚也。十年乃字，反常也。",
                "《象》曰：“即鹿无虞”，以従禽也。君子舍之，往吝穷也。",
                "《象》曰：求而往，明也。",
                "《象》曰：“屯其膏”，施未光也。",
                "《象》曰：“泣血涟如”，何可长也。"
            };
        }
    }
}
