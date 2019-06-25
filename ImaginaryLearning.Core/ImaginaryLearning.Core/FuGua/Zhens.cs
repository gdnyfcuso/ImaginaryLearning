using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 震卦，六十四卦之一
    /// </summary>
    public class Zhens : FuGua
    {
        public Zhens()
        {
            XiaGua = new Zhen();
            ShangGua = new Zhen();
        }
    }
}
