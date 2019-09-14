using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 风对观
    /// </summary>
    public class Guan : FuGua
    {
        public Guan(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Xun(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Kun(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            Name = "观";
            PinYin = "Guan";
            XuGua = 20;
            GuaCi = "盥而不荐。有孚颙若。";
            TuanCi = "《彖》曰：大观在上，顺而巽，中正以观天下，观。“盥而不荐，有孚颙若”，下观而化也。观天之神道，而四时不忒，圣人以神道设教，而天下服矣。";
            GuaXiangCi = "《象》曰：风行地上，观。先王以省方观民设教。";
            YaoCi = new string[]
            {
                "初六，童观，小人无咎，君子吝。",
                "六二，窥观，利女贞。",
                "六三，观我生，进退。",
                "六四，观国之光，利用宾于王。",
                "九五，观我生，君子无咎。",
                "上九，观其生，君子无咎。"
            };
            XiangCi = new string[]
            {
                "《象》曰：“初六童观”，“小人”道也。",
                "《象》曰：“窥观女贞”，亦可丑也。",
                "《象》曰：“观我生进退”，未失道也。",
                "《象》曰：“观国之光”，尚宾也。",
                "《象》曰：“观我生”，观民也。",
                "《象》曰：“观其生”，志未平也。"
            };
        }
    }
}