using System;
using System.Collections.Generic;
using System.Text;

namespace ImaginaryLearning.Core.Model
{
    /// <summary>
    /// 存储矩形的四个坐标点
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public abstract class YaoRectangleBase<TPoint>
    {
        /// <summary>
        /// 左上点
        /// </summary>
        public TPoint LeftUpPoint { get; set; }

        /// <summary>
        /// 左下点
        /// </summary>
        public TPoint LeftDownPoint { get; set; }

        /// <summary>
        /// 右下点
        /// </summary>
        public TPoint RightDownPoint { get; set; }

        /// <summary>
        /// 右上点
        /// </summary>
        public TPoint RightUpPoint { get; set; }
    }
}
