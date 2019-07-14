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
        public RectangleF LeftRectangle { get; set; }


        /// <summary>
        /// 阴爻分段，计算机画图要显示的右边区域
        /// </summary>
        public RectangleF RightRectangle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="startPoint">左上角的起始位置</param>
        /// <param name="totalWidth">整个爻的宽度</param>
        /// <param name="midWidth">阴爻中间的空白宽度</param>
        /// <param name="heigth">爻的高度</param>
        public YinYao(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            this.InitYinYaoInfo(startPoint, totalWidth, midWidth, heigth);
        }

        /// <summary>
        /// 通过坐标点，总宽度25，中间宽度5，高度5
        /// </summary>
        /// <param name="point">起始坐标</param>
        public YinYao(Point point)
        {
            this.InitYinYaoInfo(point, 25, 5, 5);
        }

        /// <summary>
        /// 使用默认值坐标0，0，总宽度25，中间宽度5，高度5
        /// </summary>
        public YinYao() : this(new Point(0, 0))
        {

        }


        private void InitYinYaoInfo(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            Yin = new Yin();
            YaoName = Yin.Name + YaoName;
            var width = (totalWidth - midWidth) / 2;
            var size = new Size(width, heigth);
            RectangleList = new List<RectangleF>();
            LeftRectangle = new RectangleF(startPoint, size);
            RectangleList.Add(LeftRectangle);
            var secondPoint = new PointF(startPoint.X + width + midWidth, startPoint.Y);
            RightRectangle = new RectangleF(secondPoint, size);
            RectangleList.Add(RightRectangle);
        }

        /// <summary>
        /// 通过重写该方法来获得阳爻的显示名称
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Yin.Name;
        }
    }
}
