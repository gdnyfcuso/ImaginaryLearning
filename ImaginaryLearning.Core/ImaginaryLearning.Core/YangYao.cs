using System;
using System.Collections.Generic;
using System.Text;

namespace ImaginaryLearning.Core
{
    public class YangYao : Yao
    {
        public Yang Yang { get; set; }
        public YangYao()
        {
            Yang = new Yang();
        }
        public override string ToString()
        {
            return Yang.Name + base.YaoName;
        }

    }
}
