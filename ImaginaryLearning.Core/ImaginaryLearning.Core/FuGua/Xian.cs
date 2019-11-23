using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    public class Xian : FuGua
    {
        public Xian(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Dui(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Gen(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            Name = "咸";
            XuGua = 31;
            PinYin = "Xian";
            GuaCi = "亨。利贞。取女吉。";
            GuaXiangCi = "《象》曰：山上有泽，咸。君子以虚受人。";
            TuanCi = "《彖》曰：咸，感也。柔上而刚下，二气感应以相与。止而说，男下女，是以“亨利贞，取女吉”也。天地感而万物化生，圣人感人心而天下和平。观其所感，而天地万物之情可见矣。";
            YaoCi = new string[]
            {
                "初六，咸其拇。",
                "六二，咸其腓，凶。居吉。",
                " 九三，咸其股，执其随，往吝。",
                " 九四，贞吉。悔亡。憧憧往来，朋従尔思。",
                " 九五，咸其脢，无悔。",
                "上六，咸其辅颊舌。"
            };
            XiangCi = new string[]
            {
                "《象》曰“咸其拇”，志在外也。",
                "《象》曰虽“凶居吉”，顺不害也。",
                "《象》曰：“咸其股”，亦不处也。志在随人，所执下也。",
                "《象》曰：“贞吉悔亡”，未感害也。“憧憧往来”，未光大也。",
                "《象》曰：“咸其脢”，志末也。",
                "《象》曰：“咸其辅颊舌”，滕口说也。"
            };
        }
    }
}
