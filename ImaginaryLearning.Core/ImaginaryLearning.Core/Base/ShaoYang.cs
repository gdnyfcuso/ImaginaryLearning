using System;
using System.Collections.Generic;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 少阳，内有两爻，从下往上数，初为阴爻，二为阳爻
    /// </summary>
    public class ShaoYang
    {
        /// <summary>
        /// 初爻为阴爻
        /// </summary>
        public YinYao ChuYao { get; set; }

        /// <summary>
        /// 二爻为阳爻
        /// </summary>
        public YangYao ErYao { get; set; }
    }
}
