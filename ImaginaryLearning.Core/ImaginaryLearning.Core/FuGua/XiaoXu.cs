using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 乾为天，巽为风，风飘行天上，微畜而未下行。畜有畜聚、畜养、畜止之义。小畜象征小有畜聚，所畜甚微之象。以小畜大，以下济上，有利于刚大者之行。但阴气从西方升起聚阳甚微，不足以成雨。
    /// </summary>
    public class XiaoXu : FuGua
    {
        public XiaoXu(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {

        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            XiaGua = new Qian(CreateXiaGuaPoint(startPoint, heigth), totalWidth, heigth);
            ShangGua = new Xun(startPoint, totalWidth, midWidth, heigth);
            Name = "小畜";
            PinYin = "XiaoXu";
            GuaCi = "亨。密云不雨。自我西郊。";
            XuGua = 9;
            TuanCi = "《彖》曰：“小畜”，柔得位而上下应之，曰小畜。健而巽，刚中而志行，乃亨。“密云不雨”，尚往也。“自我西郊”，施未行也。";
            GuaXiangCi = "《象》曰：风行天上，“小畜”。君子以懿文德。";
            YaoCi = new string[]
            {
                "初九，“复自道，何其咎？吉。",
                "九二，牵复，吉。",
                "九三，舆说辐。夫妻反目。",
                "六四，有孚，血去，惕出无咎。",
                "九五，有孚挛如，富以其邻。",
                "上九，既雨既处，尚德载。妇贞厉。月几望，君子征凶。"
            };
            XiangCi = new string[]
            {
                "《象》曰：“复自道”，其义“吉”也。",
                "《象》曰：牵复在中，亦不自失也。",
                "《象》曰：“夫妻反目”，不能正室也。",
                "《象》曰：“有孚惕出”，上合志也。",
                "《象》曰：“有孚挛如”，不独富也。",
                "《象》曰：“既雨既处”，德积载也。“君子征凶”，有所疑也。"
            };
        }
    }
}
