using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    public class Jian : FuGua
    {
        public Jian(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Kan(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Gen(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            Name = "蹇";
            PinYin = "Jian";
            XuGua = 39;
            GuaCi = "利西南，不利东北。利见大人。贞吉。";
            TuanCi = "《彖》曰：蹇，难也，险在前也。见险而能止，知矣哉！蹇，利西南”，往得中也。“不利东北”，其道穷也。“利见大人”，往有功也。当位”贞吉”，以正邦也。蹇之时用大矣哉！";
            GuaXiangCi = " 《象》曰：山上有水，蹇。君子以反身修德。";
            YaoCi = new string[]
            {
                "初六，往蹇来誉。",
                "六二，王臣蹇蹇，匪躬之故。",
                "九三，往蹇来反。",
                "六四，往蹇来连。",
                "九五，大蹇朋来。",
                "上六，往蹇来硕，吉，利见大人。"
            };
            XiangCi = new string[]
            {
                "《象》曰：“往蹇来誉”，宜待也。",
                "《象》曰：“王臣蹇蹇”，终无尤也。",
                "《象》曰：“往蹇来反”，内喜之也。",
                "《象》曰：“往蹇来连”，当位实也。",
                "《象》曰：“大蹇朋来”，以中节也。",
                "《象》曰：“往蹇来硕”，志在内也。“利见大人”，以従贵也。"
            };
        }
    }
}