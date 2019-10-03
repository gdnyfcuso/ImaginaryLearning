using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    public class DaZhuang : FuGua
    {
        public DaZhuang(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Gen(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Qian(CreateXiaGuaPoint(startPoint, heigth), totalWidth, heigth);
            Name = "大壮";
            PinYin = "DaZhuang";
            XuGua = 36;
            GuaCi = "利贞。";
            TuanCi = "《彖》曰：大壮，大者壮也。刚以动，故壮。“大壮利贞”，大者正也。正大，而天地之情可见矣。";
            GuaXiangCi = "《象》曰：雷在天上，大壮。君子以非礼弗履。";
            YaoCi = new string[]
            {
                "初九，壮于趾，征凶，有孚。",
                "九二，贞吉。",
                "九三，小人用壮，君子用罔，贞厉。羝羊触藩，羸其角。",
                "九四，贞吉，悔亡。藩决不羸，壮于大舆之輹。",
                "六五，丧羊于易，无悔。",
                "上六，羝羊触藩，不能退，不能遂，无攸利，艰则吉。"
            };
            XiangCi = new string[] {

                "《象》曰：“壮于趾”，其孚穷也。",
                "《象》曰：九二“贞吉”，以中也。",
                "《象》曰：“小人用壮”，君子以罔也。",
                "《象》曰：“藩决不羸”，尚往也。",
                "《象》曰：“丧羊于易”，位不当也。",
                "《象》曰：“不能退，不能遂”，不详也。“艰则吉”，咎不长也。"
            };
      }
    }
}