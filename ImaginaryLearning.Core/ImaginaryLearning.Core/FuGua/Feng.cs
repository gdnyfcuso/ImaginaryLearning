using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
  public  class Feng : FuGua
    {
        public Feng(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Zhen(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Li(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            Name = "丰";
            PinYin = "Feng";
            XuGua = 55;
            GuaCi = "亨，王假之。勿忧，宜日中。";
            GuaXiangCi = "《象》曰：雷电皆至，丰。君子以折狱致刑。";
            TuanCi = "《彖》曰：丰，大也。明以动，故丰。“王假之”，尚大也。“勿忧宜日中”，宜照天下也。日中则昃，月盈则食，天地盈虚，与时消息，而况于人乎，况于鬼神乎？";
            YaoCi = new string[]
            {
                "初九，遇其配主，虽旬无咎，往有尚。",
                "六二，丰其蔀，日中见斗。往得疑疾，有孚发若，吉。",
                "九三，丰其沛，日中见沫，折其右肱，无咎。",
                "九四，丰其蔀，日中见斗，遇其夷主，吉。",
                "六五，来章有庆誉，吉。",
                "上六，丰其屋，蔀其家，窥其户，阒其无人，三岁不觌，凶。"

            };
            XiangCi = new string[]
            {
                "《象》曰：“虽旬无咎”，过旬灾也。",
                "《象》曰：“有孚发若”，信以发志也。",
                "《象》曰：“丰其沛”，不可大事也。“折其右肱”，终不可用也。",
                "《象》曰：“丰其蔀”，位不当也。“日中见斗”，幽不明也。“遇其夷主”，吉行也。",
                "《象》曰：六五之吉，有庆也。",
                "《象》曰：“丰其屋”，天际翔也。“窥其户，阒其无人”，自藏也。"
            };

        }
    }
}
