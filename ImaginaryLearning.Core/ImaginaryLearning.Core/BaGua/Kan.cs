using System;
using System.Collections.Generic;
using System.Text;

namespace ImaginaryLearning.Core.BaGua
{
    /// <summary>
    /// 坎
    /// </summary>
    public class Kan : DanGua
    {
        public Kan()
        {
            ChuYao = new YinYao();
            ErYao = new YangYao();
            SanYao = new YinYao();
            Name = "坎";
        }
    }
}
