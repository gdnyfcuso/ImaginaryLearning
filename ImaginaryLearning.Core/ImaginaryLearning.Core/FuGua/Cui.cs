using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 泽地萃
    /// </summary>
    public class Cui : FuGua
    {
        public Cui(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Dui(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Kun(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            Name = "萃";
            PinYin = "Cui";
            XuGua = 45;
            GuaCi = "亨，王假有庙。利见大人。亨，利贞，用大牲吉。利有攸往。";
            TuanCi = "《彖》曰：“萃”，聚也。顺以说，刚中而应，故聚也。“王假有庙”，致孝享也。“利见大人亨”，聚以正也。“用大牲吉，利有攸往”，顺天命也。观其所聚，而天地万物之情可见矣。";
            GuaXiangCi = "《象》曰：泽上于地，萃。君子以除戎器，戒不虞。";
            YaoCi = new string[]
           {
                "初六，有孚不终，乃乱乃萃，若号，一握为笑，勿恤，往无咎。",
                "六二，引吉，无咎，孚乃利用禴。",
                "六三，萃如嗟如，无攸利，往无咎，小吝。",
                "九四，大吉无咎。",
                "九五，萃有位，无咎。匪孚，元永贞，悔亡。",
                "上六，赍咨涕洟，无咎。"
           };
            XiangCi = new string[]
            {
                "《象》曰：“乃乱乃萃”，其志乱也。",
                "《象》曰：“引吉无咎”，中未变也。",
                "《象》曰：“往无咎”，上巽也。",
                "《象》曰：“大吉无咎”，位不当也。",
                "《象》曰：“萃有位”，志未光也。",
                "《象》曰：“赍咨涕洟”，未安上也。"
            };
        }
    }
}
