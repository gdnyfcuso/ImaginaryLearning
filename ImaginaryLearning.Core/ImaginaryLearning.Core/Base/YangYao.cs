using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    public class YangYao : Yao
    {
        public Yang Yang { get; set; }

        public Rectangle Rectangle { get; set; }

        public YangYao() : this(new Point(0, 0))
        {

        }

        public YangYao(Point point)
        {
            this.InitYinYaoInfo(point, 30, 5, 0);

        }

        public YangYao(Point startPoint, int totalWidth, int heigth, int midWidth = 0)
        {
            this.InitYinYaoInfo(startPoint, totalWidth, midWidth, heigth);
        }

        private void InitYinYaoInfo(Point startPoint, int totalWidth, int heigth, int midWidth = 0)
        {
            Yang = new Yang();
            YaoName = Yang.Name + YaoName;
            var size = new Size(totalWidth, heigth);
            Rectangle = new Rectangle(startPoint, size);
            RectangleList.Add(Rectangle);
        }

        public override string ToString()
        {
            return YaoName;
        }
    }
}
