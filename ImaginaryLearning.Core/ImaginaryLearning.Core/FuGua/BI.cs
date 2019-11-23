using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 比卦，亲比，亲密的辅佐。
    /// 冲为地，坎为水，地上有水。
    /// 水得地而蓄而流，地得水而柔而润，水与地亲密无间。
    /// 比者，辅也，密也。故比象征亲密比辅。
    /// 彼此能亲密比辅自然吉祥，但应比辅于守持正固而有德的长者，择善而从。
    /// </summary>
    public class BI : FuGua
    {
        public BI(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            XiaGua = new Kun(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            ShangGua = new Kan(startPoint, totalWidth, midWidth, heigth);
            Name = "比";
            PinYin = "Bi";
            XuGua = 8;
            GuaCi = "吉。原筮，元，永贞，无咎。不宁方来，后夫凶。";
            GuaXiangCi = "《象》曰：地上有水，比。先王以建万国，亲诸侯。";
            TuanCi = "《彖》曰：比，吉也；比，辅也，下顺従也。“原筮，元永贞，无咎”，以刚中也。“不宁方来”，上下应也。“后夫凶”，其道穷也。";
            XiangCi = new string[] {
                "《象》曰：比之初六，有它吉也。",
                "《象》曰：“比之自内”，不自失也。",
                "《象》曰：比之匪人”，不亦伤乎？斋",
                "《象》曰：外比于贤，以従上也。",
                "《象》曰：“显比”之吉，位正中也。舍逆取顺，失前禽也。邑人不诫，上使中也。",
                "《象》曰：“比之无首”，无所终也。"
            };
            YaoCi = new string[] {
                "初六，有孚比之，无咎。有孚盈缶，终来有它，吉。",
                "六二，比之自内，贞吉。",
                "六三，比之匪人。",
                "六四，外比之，贞吉。",
                "九五，显比，王用三驱，失前禽，邑人不诫，吉。",
                "上六，比之无首，凶。"
            };

        }
    }
}
