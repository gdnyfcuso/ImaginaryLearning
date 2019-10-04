using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 风火家人
    /// </summary>
    public class JiaRen : FuGua
    {
        public JiaRen(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Xun(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Li(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            PinYin = "JiaRen";
            Name = "家人";
            XuGua = 37;
            GuaCi = "利女贞。";
            TuanCi = "《彖》曰：家人，女正位乎内，男正位乎外。男女正，天地之大义也。家人有严君焉，父母之谓也。父父，子子，兄兄，弟弟，夫夫，妇妇，而家道正。正家而天下定矣。";
            GuaXiangCi = " 《象》曰：风自火出，家人。君子以言有物而行有恒。";
            YaoCi = new string[]
            {
                " 初九，闲有家，悔亡。",
                " 六二，无攸遂，在中馈，贞吉。",
                "九三，家人嗃々，悔厉吉；妇子嘻嘻，终吝。",
                "九四，富家，大吉。",
                "九五，王假有家，勿恤，吉。",
                "上九，有孚威如，终吉。"
            };
            XiangCi = new string[]
            {
                "《象》曰：“闲有家”，志未变也。",
                "《象》曰：六二之吉，顺以巽也。",
                "《象》曰：“家人嗃々”，未失也。“妇子嘻嘻”，失家节也。",
                "《象》曰：“富家大吉”，顺在位也。",
                "《象》曰：“王假有家”，交相爱也。",
                "《象》曰：威如之吉，反身之谓也。"
            };

        }
    }
}
