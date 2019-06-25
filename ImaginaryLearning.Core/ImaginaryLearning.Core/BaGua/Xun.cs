using System;
using System.Collections.Generic;
using System.Text;

namespace ImaginaryLearning.Core.BaGua
{
    /// <summary>
    /// 巽 
    /// </summary>
    public class Xun : DanGua
    {
        public Xun()
        {
            ChuYao = new YinYao();
            ErYao = new YangYao();
            SanYao = new YangYao();
           
        }
    }
}
