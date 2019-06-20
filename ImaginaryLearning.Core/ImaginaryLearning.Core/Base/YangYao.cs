using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    public class YangYao : Yao
    {
        public Yang Yang { get; set; }

        public Rectangle Rectangle { get; set; }

        public YangYao()
        {
            Yang = new Yang();
            YaoName = Yang.Name + YaoName;
        }
        public override string ToString()
        {
            return YaoName;
        }
    }
}
