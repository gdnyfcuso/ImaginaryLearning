using System;
using System.Collections.Generic;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 太阴，内有两爻，从下往上数，初为阴爻，二为阴爻
    /// </summary>
    public class TaiYin
    {
        /// <summary>
        /// 初爻为阴爻
        /// </summary>
        public YinYao ChuYao { get; set; }

        /// <summary>
        /// 二爻为阴爻
        /// </summary>
        public YinYao ErYao { get; set; }
    }
}
