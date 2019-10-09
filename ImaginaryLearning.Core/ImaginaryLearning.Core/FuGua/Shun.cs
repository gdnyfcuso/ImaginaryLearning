using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 损 山泽
    /// </summary>
    public class Shun : FuGua
    {
        public Shun(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Gen(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Dui(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            Name = "损";
            PinYin = "Shun";
            XuGua = 41;
            GuaCi = "有孚，元吉，无咎。可贞，利有攸往。曷之用？二簋可用享。";
            TuanCi = "《彖》曰：损，损下益上，其道上行。损而有孚，元吉，无咎，可贞，利有攸往，曷之用？二簋可用享。二簋应有时。损刚益柔有时，损益盈虚，与时偕行。";
            GuaXiangCi = "《象》曰：山下有泽，损。君子以惩忿窒欲。";
            YaoCi = new string[]
            {
                "初九，已事遄往，无咎。酌损之。",
                "九二，利贞。征凶，弗损，益之。",
                "六三，三人行则损一人，一人行则得其友。",
                "六四，损其疾，使遄有喜，无咎。",
                " 六五，或益之十朋之龟，弗克违，元吉。",
                "上九，弗损，益之，无咎，贞吉，利有攸往，得臣无家。"
            };
            XiangCi = new string[]
            {
                "《象》曰：“已事遄往”，尚合志也。",
                "《象》曰：“九二利贞”，中以为志也。",
                "《象》曰：“一人行”，“三”则疑也。",
                "《象》曰：“损其疾”，亦可喜也。",
                "《象》曰：六五元吉，自上祐也。",
                "《象》曰：“弗损，益之”，大得志也。"
            };
        }
    }
}
