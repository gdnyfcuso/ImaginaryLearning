using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    public class Ge : FuGua
    {
        public Ge(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Dui(startPoint,totalWidth,midWidth,heigth);
            XiaGua = new Li(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            Name = "革";
            PinYin = "Ge";
            XuGua = 49;
            GuaCi = "已日乃孚。元亨。利贞，悔亡。";
            TuanCi = "《彖》曰：革，水火相息，二女同居，其志不相得曰革。“已日乃孚”，革而信之。文明以说，大亨以正。革而当，其悔乃亡。天地革而四时成，汤武革命，顺乎天而应乎人。革之时大矣哉！";
            GuaXiangCi = "《象》曰：泽中有火，革。君子以治历明时。";
            YaoCi = new string[]
            {
                "初九，巩用黄牛之革。",
                "六二，巳日乃革之，征吉，无咎。",
                "九三，征凶。贞厉。革言三就，有孚。",
                "九四，悔亡。有孚改命，吉。",
                "九五，大人虎变，未占有孚。",
                "上六，君子豹变，小人革面，征凶，居贞吉。"
            };
            XiangCi = new string[]
            {
                "《象》曰：“巩用黄牛”，不可以有为也。",
                "《象》曰：“巳日革之”，行有嘉也。",
                "《象》曰：“革言三就”，又何之矣。",
                "《象》曰：“改命之吉”，信志也。",
                "《象》曰：“大人虎变”，其文炳也。",
                "《象》曰：“君子豹变”，其文蔚也。“小人革面”，顺以从君也。"
            };
        }
    }
}
