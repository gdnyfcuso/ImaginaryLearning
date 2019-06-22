using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImaginaryLearning.Core
{
    public class Tai : FuGua
    {
        public Tai()
        {
            XiaGua = new Qian();
            ShangGua = new Kun();
            Name = "泰";
        }
    }
}
