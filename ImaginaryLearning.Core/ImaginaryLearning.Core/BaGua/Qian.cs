using System;
using System.Collections.Generic;
using System.Text;

namespace ImaginaryLearning.Core.BaGua
{
    /// <summary>
    /// 乾卦
    /// </summary>
    public class Qian : DanGua
    {
        public Qian()
        {
            ChuYao = new YangYao();
            ErYao = new YangYao();
            SanYao = new YangYao();
            Name = "乾";
        }
    }
}
