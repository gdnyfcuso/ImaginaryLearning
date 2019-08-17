using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 山水蒙
    /// </summary>
    public class Meng : FuGua
    {
        public Meng(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            XiaGua = new Kan(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            ShangGua = new Gen(startPoint, totalWidth, midWidth, heigth);
            Name = "蒙";
            PinYin = "Meng";
            XuGua = 4;
            GuaCi = "亨。匪我求童蒙，童蒙求我。初筮告，再三渎，渎则不告。利贞。";
            TuanCi = "《彖》曰：蒙，山下有险，险而止，蒙。" +
                "“蒙亨”，以亨行，时中也。" +
                "“匪我求童蒙，童蒙求我”。" +
                "志应也。“初筮告”，以刚中也。" +
                "“再三渎，渎则不告”，渎蒙也。" +
                "蒙以养正，圣功也。";
            GuaXiangCi = "《象》曰：山下出泉，蒙。君子以果行育德。";

            YaoCi = new string[]
            {
                "初六，发蒙，利用刑人，用说桎梏，以往吝。",
                "九二，包蒙，吉。纳妇，吉。子克家。",
                "六三，勿用取女，见金夫，不有躬。无攸利。",
                "六四，困蒙，吝。",
                "六五，童蒙，吉。",
                "上九，击蒙，不利为寇，利御寇。",
            };
            XiangCi = new string[]
            {
                "《象》曰：“利用刑人”，以正法也。",
                "《象》曰：“子克家”，刚柔节也。",
                "《象》曰：“勿用取女”，行不顺也。",
                "《象》曰：“困蒙之吝”，独远实也。",
                "《象》曰：“童蒙”之“吉”，顺以巽也。",
                "《象》曰：“利”用“御寇”，上下顺也。"
            };
        }
    }
}
