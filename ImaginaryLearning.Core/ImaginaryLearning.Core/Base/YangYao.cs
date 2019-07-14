using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    public class YangYao : Yao
    {
        public Yang Yang { get; set; }

        public RectangleF Rectangle { get; set; }

        public YangYao() : this(new PointF(0, 0))
        {

        }

        public YangYao(PointF point)
        {
            this.InitYinYaoInfo(point, 30, 5, 0);

        }

        public YangYao(PointF startPoint, int totalWidth, int heigth, int midWidth = 0)
        {
            this.InitYinYaoInfo(startPoint, totalWidth, heigth, midWidth);
        }

        private void InitYinYaoInfo(PointF startPoint, int totalWidth, int heigth, int midWidth = 0)
        {
            Yang = new Yang();
            YaoName = Yang.Name + YaoName;
            var size = new Size(totalWidth, heigth);
            Rectangle = new RectangleF(startPoint, size);
            if (RectangleList == null)
                RectangleList = new List<RectangleF>();
            RectangleList.Add(Rectangle);
        }

        public override string ToString()
        {
            return YaoName;
        }
    }
}
