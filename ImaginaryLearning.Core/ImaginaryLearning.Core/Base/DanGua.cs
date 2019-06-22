using System;
using System.Collections.Generic;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 指有三爻组成的卦通过阴阳爻共组合成八中种卦
    /// </summary>
    public class DanGua
    {
        public Yao ChuYao { get; set; }

        public Yao ErYao { get; set; }

        public Yao SanYao { get; set; }

        public string Name { get; set; }
    }
}
