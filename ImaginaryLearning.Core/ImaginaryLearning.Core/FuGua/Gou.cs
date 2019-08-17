using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    public class Gou : FuGua
    {
        public Gou(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            XiaGua = new Xun(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            ShangGua = new Qian(startPoint, totalWidth, heigth);
            Name = "姤";
            PinYin = "Gou";
            IsTwelvePIGua = true;
            GuaCi = "女壮，勿用取女。";
            TuanCi = "姤，遇也，柔遇刚也。勿用取女”，不可与长也。天地相遇，品物咸章也。刚遇中正，天下大行也。姤之时义大矣哉！";
            GuaXiangCi = "《象》曰：天下有风，姤。后以施命诰四方。";
            YaoCi = new string[]
            {
                "初六，系于金柅，贞吉。有攸往，见凶，羸豕孚蹢躅。",
                "九二，包有鱼，无咎，不利宾。",
                "九三，臀无肤，其行次且，厉，无大咎。",
                "九四，包无鱼，起凶。",
                "九五，以杞包瓜，含章，有陨自天。",
                "上九，姤其角，吝，无咎。"
            };
            XiangCi = new string[]
            {
                "《象》曰：“系于金柅”，柔道牵也。",
                "《象》曰：“包有鱼”，义不及宾也。",
                "《象》曰：“其行次且”，行未牵也。",
                "《象》曰：“无鱼之凶”，远民也。",
                "《象》曰：九五含章，中正也。有陨自天，志不舍命也。",
                "《象》曰：“姤其角”，上穷吝也。"
            };
        }
    }
}
