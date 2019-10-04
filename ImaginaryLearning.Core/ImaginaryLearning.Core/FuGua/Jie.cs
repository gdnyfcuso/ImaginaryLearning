using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    public class Jie : FuGua
    {
        public Jie(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        { 
            ShangGua = new Zhen(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Kan(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            Name = "解";
            PinYin = "Jie";
            XuGua = 40;
            GuaCi = "《解》：利西南。无所往，其来复吉。有攸往，夙吉。";
            TuanCi = "《彖》曰：解，险以动，动而免乎险，解。“解，利西南”，往得众也。“其来复吉”，乃得中也。“有攸往夙吉。”，往有功也。天地解而雷雨作，雷雨作而百果草木皆甲坼。解之时大矣哉！";
            GuaXiangCi = "《象》曰：雷雨作，解。君子以赦过宥罪。";
            YaoCi = new string[]
            {
                "初六，无咎。",
                "九二，田获三狐，得黄矢，贞吉。",
                "六三，负且乘，致寇至，贞吝。",
                " 九四，解而拇，朋至斯孚。",
                " 六五，君子维有解，吉，有孚于小人。",
                "上六，公用射隼于高墉之上，获之，无不利。",
            };
            XiangCi = new string[]
            {
                "《象》曰：刚柔之际，义无咎也。",
                "《象》曰：九二贞吉，得中道也。",
                "《象》曰：“负且乘”，亦可丑也。自我致戎，又谁咎也？斋",
                "《象》曰：“解而拇”，未当位也。",
                "《象》曰：君子有解，小人退也。",
                "《象》曰：“公用射隼”，以解悖也。"
            };
        }
    }
}
