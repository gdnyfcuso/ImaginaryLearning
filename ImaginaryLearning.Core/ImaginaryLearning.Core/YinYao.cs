using System;
using System.Collections.Generic;
using System.Text;

namespace ImaginaryLearning.Core
{
    public class YinYao : Yao
    {
        public Yin Yin { get; set; }

        public YinYao()
        {
            Yin = new Yin();
        }

        public override string ToString()
        {
            return Yin.Name + base.YaoName;
        }
    }
}
