using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 六十四卦的乾卦，由两个单乾卦上下组而成
    /// </summary>
    public class Qians : FuGua
    {
        public Qians(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {

        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            XiaGua = new Qian(CreateXiaGuaPoint(startPoint, heigth), totalWidth, heigth);
            ShangGua = new Qian(startPoint, totalWidth, heigth);
            Name = "乾";
            PinYin = "Qian";
            IsTwelvePIGua = true;
            XuGua = 1;
            GuaCi = "元，亨，利，贞。";
            TuanCi = "《彖》曰：大哉乾元，万物资始，乃统天。" +
                "云行雨施，品物流形。大明终始，六位时成。" +
                "时乘六龙以御天。乾道变化，各正性命。" +
                "保合大和，乃利贞。首出庶物，万国威宁。";
            GuaXiangCi = "《象》曰：天行健，君子以自强不息。" +
                "“潜龙勿用”，阳在下也。" +
                "“见龙在田”，德施普也。" +
                "“终日乾乾”，反复道也。" +
                "“或跃在渊”，进无咎也。" +
                "“飞龙在天”，大人造也。" +
                "“亢龙有悔”，盈不可久也。" +
                "“用九”，天德不可为首也。";

            YaoCi = new string[]
            {
                "潜龙勿用。",
                "见（xiàn）龙在田，利见大人。",
                "君子终日乾乾，夕惕若厉，无咎。",
                "或跃在渊，无咎。",
                "飞龙在天，利见大人。",
                "亢龙有悔。",
                "见群龙无首，吉。"
            };
            XiangCi = new string[]
            {
                "初九曰“潜龙勿用”，何谓也？子曰：“龙，德而隐者也。不易乎世，不成乎名，遯世无闷，不见是而无闷。乐则行之，忧则违之，确乎其不可拔，潜龙也。”",
                "九二曰“见龙在田，利见大人”，何谓也？子曰：“龙德而正中者也。庸言之信，庸行之谨，闲邪存其诚，善世而不伐，德博而化。《易》曰：‘见龙在田，利见大人’，君德也。”",
                "九三曰“君子终日乾乾，夕惕若，厉无咎”，何谓也？子曰：“君子进德修业。忠信所以进德也。修辞立其诚，所以居业也。知至至之，可与言几也。知终终之，可与存义也。是故居上位而不骄，在下位而不忧，故乾乾因其时而惕，虽危无咎矣。”",
                "九四曰“或跃在渊，无咎”，何谓也？子曰：“上下无常，非为邪也。进退无恒，非离群也。君子进德修业，欲及时也，故无咎。”",
                "九五曰“飞龙在天，利见大人”，何谓也？子曰：“同声相应，同气相求。水流湿，火就燥，云従龙，风従虎，圣人作而万物睹。本乎天者亲上，本乎地者亲下，则各従其类也。”",
                "上九曰“亢龙有悔”，何谓也？子曰：“贵而无位，高而无民，贤人在下位而无辅，是以动而有悔也。”"
            };
        }
    }
}
