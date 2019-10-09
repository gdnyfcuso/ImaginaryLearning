using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 泽天夬
    /// </summary>
    public class Guai : FuGua
    {
        public Guai(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Dui(startPoint,totalWidth,midWidth,heigth);
            XiaGua = new Qian(CreateXiaGuaPoint(startPoint, heigth), totalWidth, heigth);
            Name = "夬";
            PinYin = "Guai";
            XuGua = 43;
            GuaCi = "扬于王庭，孚号。有厉，告自邑。不利即戎，利有攸往。";
            TuanCi = "《彖》曰：“夬”，决也，刚决柔也。健而说，决而和。“扬于王庭”，柔乘五刚也。“孚号有厉”，其危乃光也。“告自邑，不利即戎”，所尚乃穷也。“利有攸往”，刚长乃终也。";
            GuaXiangCi = "《象》曰：泽上于天，夬。君子以施禄及下，居德则忌。";
            YaoCi = new string[]
            {
                " 初九，壮于前趾，往不胜，为咎。",
                "九二，惕号，莫夜有戎，勿恤。",
                " 九三，壮于頄，有凶。君子夬夬独行，遇雨若濡，有愠无咎。",
                "九四，臀无肤，其行次且。牵羊悔亡，闻言不信。",
                " 九五，苋陆夬夬中行，无咎。",
                " 上六，无号，终有凶。"
            };
            XiangCi = new string[]
            {
                "《象》曰：不胜而往，咎也。",
                "《象》曰：“有戎勿恤”，得中道也。",
                "《象》曰：“君子夬夬”，终无咎也。",
                "《象》曰：“其行次且”，位不当也。“闻言不信”，聪不明也。",
                "《象》曰：“中行无咎”，中未光也。",
                "《象》曰：“无号之凶”，终不可长也。"
            };
        }
    }
}
