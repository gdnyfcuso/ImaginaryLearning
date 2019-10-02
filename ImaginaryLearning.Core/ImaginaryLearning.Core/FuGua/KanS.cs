using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    public class KanS : FuGua
    {
        public KanS(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Kan(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Kan(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            Name = "坎";
            XuGua = 31;
            PinYin = "Kan";
            GuaCi = "有孚维心，亨。行有尚。";
            GuaXiangCi = "《象》曰：水洊至，习坎。君子以常德行，习教事。";
            TuanCi = "《彖》曰：“习坎”，重险也。水流而不盈。行险而不失其信。维心亨，乃以刚中也。“行有尚”，往有功也。天险，不可升也。地险，山川丘陵也。王公设险以守其国。险之时用大矣哉！";
            YaoCi = new string[] {
                " 初六，习坎，入于坎，窞，凶。" ,
                " 九二，坎有险，求小得。",
                "六三，来之坎，坎险且枕，入于坎，窞，勿用。",
                "六四，樽酒簋贰用缶，纳约自牖，终无咎。",
                " 九五，坎不盈，祗既平，无咎。",
                "上六，系用徽纆，窴于丛棘，三岁不得，凶。"
            };
            XiangCi = new string[]
            {
                "《象》曰：“习坎入坎”，失道，凶也。",
                "《象》曰：“求小得”，未出中也。",
                "《象》曰：“来之坎坎”，终无功也。",
                "《象》曰：“樽酒簋贰”，刚柔际也。",
                "《象》曰：“坎不盈”，中未大也。",
                " 《象》曰：上六失道，凶三岁也。"
            };
        }
    }
}