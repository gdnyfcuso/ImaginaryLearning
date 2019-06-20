using System;
using System.Collections.Generic;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 复卦，由两个单卦组成从下往上，依次是下卦，上卦
    /// </summary>
    public class FuGua
    {
        /// <summary>
        /// 下卦
        /// </summary>
        public DanGua XiaGua { get; set; }

        /// <summary>
        /// 上卦
        /// </summary>
        public DanGua ShangGua { get; set; }
    }
}
