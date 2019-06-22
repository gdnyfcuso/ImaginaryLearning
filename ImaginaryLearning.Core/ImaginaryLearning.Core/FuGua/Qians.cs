using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 六十四卦的乾卦，由两个单乾卦上下组而成
    /// </summary>
    public class Qians : FuGua
    {
        public Qians()
        {
            XiaGua = new Qian();
            ShangGua = new Qian();
            Name = "乾";
        }

    }
}
