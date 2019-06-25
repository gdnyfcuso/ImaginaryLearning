using System;
using System.Collections.Generic;
using System.Text;

namespace ImaginaryLearning.Core.BaGua
{
    /// <summary>
    /// 艮
    /// </summary>
    public class Gen : DanGua
    {
        public Gen()
        {
            ChuYao = new YinYao();
            ErYao = new YinYao();
            SanYao = new YangYao();
            Name = "艮";
        }
    }
}
