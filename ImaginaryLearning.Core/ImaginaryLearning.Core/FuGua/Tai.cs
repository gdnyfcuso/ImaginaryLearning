using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    public class Tai : FuGua
    {
        public Tai(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {

        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            XiaGua = new Qian(CreateXiaGuaPoint(startPoint, heigth), totalWidth, heigth);
            ShangGua = new Kun(startPoint, totalWidth, midWidth, heigth);
            Name = "泰";
            PinYin = "Tai";
            IsTwelvePIGua = true;
            GuaCi = "小往大来，吉，亨。";
            TuanCi = "“泰，小往大来。吉，亨。”则是天地交而万物通也，上下交而其志同也。内阳而外阴，内健而外顺，内君子而外小人，君子道长，小人道消也。";
            YaoCi = new string[]
            {
                "初九，拔茅茹以其汇。征吉。",
                "九二，包荒，用冯河，不遐遗。朋亡，得尚于中行。",
                "九三，无平不陂，无往不复。艰贞无咎。勿恤其孚，于食有福。",
                "六四，翩翩，不富以其邻，不戒以孚。",
                "六五，帝乙归妹，以祉元吉。",
                "上六，城复于隍，勿用师，自邑告命。贞吝。",
            };

            XiangCi = new string[]
            {
                "《象》曰：“拔茅征吉”，志在外也。",
                "《象》曰：“包荒，得尚于中行”，以光大也。",
                "《象》曰：“无往不复”，天地际也。",
                "《象》曰：“翩翩，不富”，皆失实也。“不戒以孚”，中心愿也。",
                "《象》曰：“以祉元吉”，中以行愿也。",
                "《象》曰：“城复于隍”，其命乱也。",
            };
        }
    }
}
