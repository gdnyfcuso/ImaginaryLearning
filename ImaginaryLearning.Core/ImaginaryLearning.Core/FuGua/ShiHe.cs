using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    public class ShiHe : FuGua
    {
        public ShiHe(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Li(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Zhen(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            Name = "噬嗑";
            PinYin = "ShiHe";
            GuaCi = "亨。利用狱。";
            TuanCi = "《彖》曰：颐中有物曰噬嗑。噬嗑而亨，刚柔分，动而明，雷电合而章。柔得中而上行，虽不当位，利用狱也。";
            GuaXiangCi = "《象》曰：雷电，噬嗑。先王以明罚敕法。";
            YaoCi = new string[] {
                "初九，屦校灭趾，无咎。",
                "六二，噬肤灭鼻，无咎。",
                "六三，噬腊肉遇毒，小吝，无咎。",
                "九四，“噬干胏，得金矢。利艰贞，吉。",
                "六五，噬干肉得黄金。贞厉，无咎。",
                "上九：何校灭耳，凶。人生启示"
            };
            XiangCi = new string[]
            {
                "《象》曰：“屦校灭趾”，不行也。",
                "《象》曰：“噬肤灭鼻”，乘刚也。",
                "《象》曰：“遇毒”，位不当也。",
                "《象》曰：“利艰贞吉”，未光也。",
                "《象》曰：“贞厉无咎”，得当也。",
                "《象》曰：“何校灭耳”，聪不明也。"
            };
        }
    }
}
