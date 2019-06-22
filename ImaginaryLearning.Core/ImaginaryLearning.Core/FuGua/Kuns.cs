using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 坤卦，复卦
    /// </summary>
    public class Kuns : FuGua
    {
        public Kuns()
        {
            XiaGua = new Kun();
            ShangGua = new Kun();
            Name = "坤";
        }
    }
}
