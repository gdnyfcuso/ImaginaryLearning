using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 火水未济
    /// </summary>
    public class WeiJi : FuGua
    {
        public WeiJi(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Li(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Kan(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            Name = "未济";
            PinYin = "WeiJi";
            XuGua = 64;
            GuaCi = "亨。小狐汔济，濡其尾，无攸利。";
            GuaXiangCi = " 《象》曰：火在水上，未济。君子以慎辨物居方。";
            TuanCi = " 《彖》曰：“未济，亨”，柔得中也。“小狐汔济”，未出中也。“濡其尾，无攸利”，不续终也。虽不当位，刚柔应也。";
            YaoCi = new string[]
            {
                " 初六，濡其尾，吝。",
                "九二，曳其轮，贞吉。",
                "六三，未济，征凶。利涉大川。",
                "九四，贞吉，悔亡，震用伐鬼方，三年，有赏于大国。",
                "六五，贞吉，无悔。君子之光，有孚吉。",
                "上九，有孚于饮酒，无咎。濡其首，有孚失是。"
            };
            XiangCi = new string[]
            {
                "《象》曰：“濡其尾”，亦不知极也。",
                "《象》曰：九二贞吉，中以行正也。",
                "《象》曰：“未济征凶”，位不当也。",
                "《象》曰：“贞吉悔亡”，志行也。",
                "《象》曰：“君子之光”，其辉吉也。",
                "《象》曰：“饮酒濡首”，亦不知节也。"
            };
        }
    }
}