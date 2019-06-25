using System;
using System.Collections.Generic;
using System.Text;

namespace ImaginaryLearning.Core.BaGua
{
    /// <summary>
    /// 震
    /// </summary>
    public class Zhen : DanGua
    {
        public Zhen()
        {
            ChuYao = new YangYao();
            ErYao = new YinYao();
            SanYao = new YinYao();
        }
    }
}
