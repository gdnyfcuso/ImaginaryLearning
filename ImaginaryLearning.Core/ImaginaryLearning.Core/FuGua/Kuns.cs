using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 坤卦，复卦
    /// </summary>
    public class Kuns : FuGua
    {
        public Kuns(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {

        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            XiaGua = new Kun(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            ShangGua = new Kun(startPoint, totalWidth, midWidth, heigth);
            Name = "坤";
            PinYin = "Kun";
            XuGua = 2;
            IsTwelvePIGua = true;
            GuaCi = "元亨。利牝马之贞。君子有攸往，先迷，後得主，利。西南得朋，东北丧朋。安贞吉。";
            TuanCi = "《彖》曰：至哉坤元，万物资生，乃顺承天。" +
                "坤厚载物，德合无疆。含弘光大，品物咸亨。" +
                "牝马地类，行地无疆，柔顺利贞。" +
                "君子。君子攸行，先迷失道，後顺得常。" +
                "西南得朋，乃与类行。东北丧朋，乃终有庆。" +
                "安贞之吉，应地无疆。";
            GuaXiangCi = "《象》曰：地势坤。君子以厚德载物。";
            XiangCi = new string[]
            {
                "《象》曰：“履霜坚冰”，阴始凝也，驯致其道，至坚冰也。",
                "《象》曰：六二之动，直以方也。“不习无不利”，地道光也。",
                "《象》曰“含章可贞”，以时发也。“或従王事”，知光大也。",
                "《象》曰：“括囊无咎”，慎不害也。",
                "《象》曰：“黄裳元吉”，文在中也。",
                "《象》曰：“龙战于野”，共道穷也。",
                "《象》曰：用六“永贞”，以大终也。"
            };
            YaoCi = new string[]
            {
                "初六：履霜，坚冰至。",
                "六二，直方大，不习，无不利。",
                "六三，含章可贞，或从王事，无成有终。",
                "六四，括囊，无咎无誉。",
                "六五，黄裳，元吉。",
                "上六，龙战于野，其血玄黄。",
                "用六，利永贞。"
            };
        }
    }
}
