using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImaginaryLearning.Core
{
    public class PI : FuGua
    {
        public PI()
        {
            XiaGua = new Kun();
            ShangGua = new Qian();
            Name = "否";
        }
    }
}
