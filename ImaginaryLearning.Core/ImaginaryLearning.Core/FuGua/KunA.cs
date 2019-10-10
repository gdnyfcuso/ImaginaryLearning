using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 泽水困
    /// </summary>
    class KunA : FuGua
    {
        public KunA(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Dui(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Kan(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            Name = "困";
            PinYin = "Kun";
            XuGua = 47;
            GuaCi = "亨。贞大人吉，无咎。有言不信。";
            GuaXiangCi = "《象》曰：泽无水，困。君子以致命遂志。";
            TuanCi = "《彖》曰：“困”，刚掩也。险以说，因而不失其所，亨，其唯君子乎。“贞大人吉”，以刚中也。“有言不信”，尚口乃穷也。";
            YaoCi = new string[]
            {
                "初六，臀困于株木，入于幽谷，三岁不觌。",
                "九二，困于酒食，朱绂方来。利用享祀。征凶，无咎。",
                "六三，困于石，据于蒺藜，入于其宫，不见其妻，凶。",
                "九四，来徐徐，困于金车，吝，有终。",
                "九五，劓刖，困于赤绂，乃徐有说，利用祭祀。",
                "上六，困于葛藟，于臲<臬兀>，曰动悔有悔，征吉。"
            };
            XiangCi = new string[]
            {
                "《象》曰：“入于幽谷”，幽不明也。",
                "《象》曰：“困于酒食”，中有庆也。",
                "《象》曰：“据于蒺藜”，乘刚也。“入于其宫，不见其妻”，不祥也。",
                "《象》曰：“来徐徐”，志在下也。虽不当位，有与也。",
                "《象》曰：“劓刖”，志未得也。“乃徐有说”，以中直也。“利用祭祀”，受福也。",
                "《象》曰：“困于葛藟”，未当也。“动悔有悔”，吉行也。"
            };
        }
    }
}
