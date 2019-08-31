using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    public class TongRen : FuGua
    {
        public TongRen(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            XiaGua = new Li(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            ShangGua = new Qian(startPoint, totalWidth, heigth);
            Name = "同人";
            XuGua = 13;
            GuaCi = "同人于野，亨。利涉大川。利君子贞。";
            TuanCi = "《彖》曰：“同人”，柔得位得中，而应乎乾，曰同人。同人曰：“同人于野，亨。利涉大川”，乾行也。文明以健，中正而应，君子正也。唯君子为能通天下之志。";
            GuaXiangCi = "《象》曰：天与火，同人。君子以类族辨物。";
            YaoCi = new string[]
            {
                "初九，同人于门，无咎。",
                "六二，同人于宗，吝。",
                "九三，伏戎于莽，升其高陵，三岁不兴。",
                "九四，乘其墉，弗克攻，吉主",
                "九五，同人先号咷而后笑，大师克，相遇。",
                "上九，同人于郊，无悔。"
            };
            XiangCi = new string[]
            {
                "《象》曰：“出门同人”，又谁咎也。",
                "《象》曰：“同人于宗”，吝道也。",
                "《象》曰：“伏戎于莽”，敌刚也。“三岁不兴”，安行也。",
                "《象》曰：“乘其墉”，义弗克也。其“吉”，则困而反则也。",
                "《象》曰：同人之先，以中直也。大师相遇，言相克也。",
                "《象》曰：“同人于郊”，志未得也。",
            };
        }
    }
}
