using System;
using System.Collections.Generic;
using System.Text;

namespace ImaginaryLearning.Core.BaGua
{
    /// <summary>
    /// 离
    /// </summary>
   public class Li:DanGua
    {
        public Li()
        {
            ChuYao = new YangYao();
            ErYao = new YinYao();
            SanYao = new YangYao();
            Name = "离";
        }
    }
}
