using ImaginaryLearning.Common.EnumHelp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 八卦方位通过文字与数字来对应
    /// <see cref="67里面的6表示先天的八卦方位对应的数字"/>
    /// <see cref="7表示后天八卦方位对应的数字"/>
    /// </summary>
    public enum BaGuaDirection
    {
        /// <summary>
        /// 正西
        /// </summary>
        [EnumDescription("正西")]
        ZX = 67,
        /// <summary>
        /// 正南
        /// </summary>
        [EnumDescription("正南")]
        ZN = 19,
        /// <summary>
        /// 正北
        /// </summary>
        [EnumDescription("正北")]
        ZB = 81,
        /// <summary>
        /// 正东
        /// </summary>
        [EnumDescription("正东")]
        ZD = 33,
        /// <summary>
        /// 东北
        /// </summary>
        [EnumDescription("东北")]
        DB = 48,
        /// <summary>
        /// 东南
        /// </summary>
        [EnumDescription("东南")]
        DN = 24,
        /// <summary>
        /// 西北
        /// </summary>
        [EnumDescription("西北")]
        XB = 76,
        /// <summary>
        /// 西南
        /// </summary>
        [EnumDescription("西南")]
        XN = 52
    }
}
