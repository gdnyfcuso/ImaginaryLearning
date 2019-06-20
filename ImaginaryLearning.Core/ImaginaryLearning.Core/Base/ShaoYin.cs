using System;
using System.Collections.Generic;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 少阴，内有两爻，从下往上数，初为阳爻，二为阴爻
    /// </summary>
    public class ShaoYin
    {
        /// <summary>
        /// 初爻为阳爻
        /// </summary>
        public YangYao ChuYao { get; set; }

        /// <summary>
        /// 二爻为阴爻
        /// </summary>
        public YinYao ErYao { get; set; }
    }
}
