using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 地雷复
    /// </summary>
    public class Fu : FuGua
    {
        public Fu(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Kun(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Zhen(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            Name = "复";
            PinYin = "Fu";
            XuGua = 25;
            GuaCi = "亨。出入无疾。朋来无咎。反复其道，七日来复，利有攸往。";
            TuanCi = " 《彖》曰：“复，亨”。刚反，动而以顺行。是以“出入无疾，朋来无咎”。“反复其道，七日来复”，天行也。“利有攸往”，刚长也。复，其见天地之心乎。";
            GuaXiangCi = "《象》曰：雷在地中，复。先王以至日闭关，商旅不行，后不省方。";
            YaoCi = new string[]
            {
                "初九，不远复，无祗悔，元吉。",
                "六二，休复，吉。",
                "六三，频复，厉，无咎。",
                "六四，中行独复。",
                "六五，敦复，无悔。",
                "上六，迷复，凶，有灾眚。用行师，终有大败，以其国君凶，至于十年不克征。"
            };
            XiangCi = new string[]
            {
                "《象》曰：“不远之复”，以修身也。",
                "《象》曰：“休复之吉”，以下仁也。",
                "《象》曰：“频复之厉”，义无咎也。",
                "《象》曰：“中行独复”，以従道也。",
                "《象》曰：“敦复无悔”，中以自考也。",
                "《象》曰：“迷复之凶”，反君道也。"
            };


        }
    }
}
