using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 阴爻两个短横
    /// </summary>
    public class YinYao : Yao
    {
        /// <summary>
        /// 阴爻具有的阴性
        /// </summary>
        public Yin Yin { get; set; }

        /// <summary>
        /// 阴爻分段，计算机画图要显示的左边区域
        /// </summary>
        public Rectangle LeftRectangle { get; set; }


        /// <summary>
        /// 阴爻分段，计算机画图要显示的右边区域
        /// </summary>
        public Rectangle RightRectangle { get; set; }

        public YinYao()
        {
            Yin = new Yin();
        }

        /// <summary>
        /// 通过重写该方法来获得阳爻的显示名称
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Yin.Name + base.YaoName;
        }
    }
}
