using System;
using System.Collections.Generic;
using System.Text;

namespace ImaginaryLearning.Core.BaGua
{
    /// <summary>
    /// 泽
    /// </summary>
   public class Ze:DanGua
    {
        public Ze()
        {
            ChuYao = new YangYao();
            ErYao = new YangYao();
            SanYao = new YinYao();
        }
    }
}
