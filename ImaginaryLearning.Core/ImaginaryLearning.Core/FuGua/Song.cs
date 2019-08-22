using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 天水讼 讼卦，象征争论、诉讼。
    /// 乾为天，坎为水，天西转与水东流背向而行，像人与人不和而争辩。
    /// 讼象征争辩争论，含诉讼之义。
    /// 当不易和解时，便会导致诉讼。
    /// 应该找有大德大才的人进行决断，不要逞强冒险。
    /// </summary>
    public class Song : FuGua
    {
        public Song(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            XiaGua = new Kan(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            ShangGua = new Qian(startPoint, totalWidth, heigth);
            Name = "讼";
            PinYin = "Song";
            XuGua = 6;
            GuaCi = "有孚窒惕，中吉，终凶。利见大人。不利涉大川。";
            TuanCi = "《彖》曰：讼，上刚下险，险而健，讼。“讼有孚窒惕，中吉”，刚来而得中也。“终凶”，讼不可成也。“利见大人”，尚中正也。“不利涉大川”，入于渊也。";
            GuaXiangCi = "《象》曰：天与水违行，讼。君子以作事谋始。";
            YaoCi = new string[]
            {
                "初六，不永所事，小有言，终吉。",
                "九二，不克讼，归而逋。其邑人三百户，无眚。",
                "六三，食旧德，贞厉，终吉。或従王事，无成。六三，食旧德，贞厉，终吉。或従王事，无成。",
                "九四，不克讼，复既命渝。安贞吉。",
                "九五：讼，元吉。",
                "上九：或锡之鞶带，终朝三褫之。"

            };
            XiangCi = new string[]
            {
                "《象》曰：“不永所事”，讼不可长也。虽“小有言”，其辩明也。",
                "《象》曰：“不克讼”，归逋窜也。自下讼上，患至掇也。",
                "《象》曰：食旧德，従上吉也。",
                "《象》曰：复即命渝，安贞不失也。",
                "《象》曰：“讼，元吉”以中正也。",
                "《象》曰：以讼受服，亦不足敬也。"
            };

        }
    }
}
