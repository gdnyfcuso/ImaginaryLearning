using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 地泽临
    /// </summary>
    public class Lin : FuGua
    {
        public Lin(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Kun(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Dui(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            Name = "临";
            PinYin = "Lin";
            XuGua = 19; 
            GuaCi = "《临》：元亨，利贞。至于八月有凶。";
            TuanCi = "《彖》曰：临，刚浸而长，说而顺，刚中而应。大亨以正，天之道也。“至于八月有凶”，消不久也。";
            GuaXiangCi = "《象》曰：泽上有地，临。君子以教思无穷，容保民无疆。";
            YaoCi = new string[]
            {
                "初九，咸临，贞吉。",
                "九二，咸临，吉，无不利。",
                "六三，甘临，无攸利；既忧之，无咎。",
                "六四，至临，无咎。",
                "六五，知临，大君之宜，吉。",
                "上六，敦临，吉，无咎。"
            };
            XiangCi = new string[]
            {
                "《象》曰：“咸临贞吉”，志行正也。",
                "《象》曰：“咸临吉无不利”，未顺命也。",
                "《象》曰：“甘临”，位不当也。“既忧之”。咎不长也。",
                "《象》曰：“至临无咎”，位当也。",
                "《象》曰：“大君之宜”，行中之谓也。",
                "《象》曰：“敦临之吉”，志在内也。"
            };
        } 
    }
}