using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 雷地豫
    /// </summary>
    public class Yv : FuGua
    {
        public Yv(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Zhen(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Kun(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            Name = "豫";
            XuGua = 16;
            PinYin = "Yv";
            GuaCi = "利建侯行师。";
            GuaXiangCi = "《象》曰：雷出地奋，豫。先王以作乐崇德，殷荐之上帝，以配祖考。";
            TuanCi = "《彖》曰：豫，刚应而志行，顺以动，豫。豫顺以动，故天地如之，而况建侯行师乎？天地以顺动，故日月不过，而四时不忒。圣人以顺动，则刑罚清而民服，豫之时义大矣哉！";
            YaoCi = new string[]
            {
                "初六，鸣豫，凶。",
                "六二，介于石，不终日，贞吉。",
                "六三，盱豫，悔，迟有悔。",
                "九四，由豫，大有得，勿疑。朋盍簪。",
                "六五，贞疾，恒不死。",
                "上六，冥豫，成有渝。无咎。"
            };
            XiangCi = new string[]
            {
                "《象》曰：“初六鸣豫”，志穷凶也。",
                "《象》曰：“不终日贞吉”，以中正也。",
                "《象》曰：“盱豫不悔”，位不当也。",
                "《象》曰：“由豫大有得”，志大行也。",
                "《象》曰：“六五贞疾”，乘刚也。“恒不死”，中未亡也。",
                "《象》曰：“冥豫”在上，何可长也？"
            };
        }
    }
}