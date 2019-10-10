using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 水风井
    /// </summary>
    public class Jing : FuGua
    {
        public Jing(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Kan(startPoint,totalWidth,midWidth,heigth);
            XiaGua = new Xun(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            Name = "井";
            PinYin = "Jing";
            XuGua = 48;
            GuaCi = "改邑不改井，无丧无得。往来井井。汔至，亦未繘井，羸其瓶，凶。";
            TuanCi = "《彖》曰：巽乎水而上水，井。井养而不穷也。“改邑不改井，”乃以刚中也。“汔至，亦未繘井”，未有功也。“羸其瓶”，是以凶也。";
            GuaXiangCi = "《象》曰：木上有水，井。君子以劳民劝相。";
            YaoCi = new string[]
            {
                "初六，井泥不食。旧井无禽。",
                "九二，井谷射鲋，瓮敝漏。",
                "九三，井渫不食，为我心恻。可用汲，王明并受其福。",
                "六四，井甃，无咎。",
                "九五，井洌，寒泉食。",
                "上六，井收勿幕，有孚元吉。"
            };
            XiangCi = new string[]
            {
                "《象》曰：“井泥不食”，下也。“占井无禽”，时舍也。",
                "《象》曰：“井谷射鲋”，无与也。",
                "《象》曰：“井渫不食”，行恻也。求“王明”，受福也。",
                "《象》曰：“井甃无咎”，修井也。",
                "《象》曰：“寒泉之食”，中正也。",
                "《象》曰：“元吉”在“上”，大成也。"
            };
        }
    }
}
