using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 履卦，象征履行、实践。乾为天，兑为泽，天在上，泽在下，为土下之正理。
    /// 又乾为刚健，兑为和悦，有和悦应合刚健之象。
    /// 履象征慎行，循礼而行的意思。遇事循礼慎行，即使有危也无害，所以诸事顺利。
    /// </summary>
    public class Lv : FuGua
    {
        public Lv(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {

        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            XiaGua = new Dui(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            ShangGua = new Qian(startPoint, totalWidth, heigth);
            Name = "履";
            PinYin = "Lv";
            XuGua = 10;
            GuaCi = "履虎尾，不咥人。亨。";
            TuanCi = "《彖》曰：“履”，柔履刚也。" +
                "说而应乎乾，是以“履虎尾，不咥人”。" +
                "亨，刚中正，履帝位而不疚，光明也。";
            GuaXiangCi = "《象》曰：上天下泽，“履”。君子以辨上下，定民志。";
            YaoCi = new string[] {
                "初九，素履往，无咎。",
                "九二，履道坦坦，幽人贞吉。",
                "六三，眇能视，跛能履，履虎尾，咥人，凶。武人为于大君。",
                "九四，履虎尾，愬愬，终吉。",
                "九五，夬履，贞厉。",
                "上九，视履考祥，其旋元吉。"
            };
            XiangCi = new string[] {
                "《象》曰：“素履之往”，独行愿也。",
                "《象》曰：“幽人贞吉”，中不自乱也。",
                "《象》曰：“眇能视”，不足以有明也。“跛能履”，不足以与行也。“咥人之凶”，位不当也。“武人为于大君”，志刚也。",
                "《象》曰：“愬愬终吉”。志行也。",
                "《象》曰：“夬履贞厉”，位正当也。",
                "《象》曰：元吉在上，大有庆也。"
            };
        }
    }
}
