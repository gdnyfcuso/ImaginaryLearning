using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 指有三爻组成的卦通过阴阳爻共组合成八中种卦
    /// </summary>
    public class DanGua
    {
        private List<Rectangle> _rectangleList = null;

        public Rectangle GuaRectangle { get; set; }

        public DanGua()
        {
            _rectangleList = new List<Rectangle>();
        }

        public Yao ChuYao { get; set; }

        public Yao ErYao { get; set; }

        public Yao SanYao { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// 别名
        /// </summary>
        public string Alias { get; set; }

        /// <summary>
        /// 卦性
        /// </summary>
        public string Nature { get; set; }

        /// <summary>
        /// 先天方位
        /// </summary>
        public string InnateOrientation { get; set; }

        /// <summary>
        /// 后天方位
        /// </summary>
        public string AcquiredAzimuth { get; set; }

        /// <summary>
        /// 后天数字
        /// </summary>
        public int NumbersAcquired { get; set; }

        /// <summary>
        /// 先天数字
        /// </summary>
        public int InnateNumber { get; set; }



        public List<Rectangle> RectangleList
        {
            get
            {
                this._rectangleList.AddRange(ChuYao.RectangleList);
                this._rectangleList.AddRange(ErYao.RectangleList);
                this._rectangleList.AddRange(SanYao.RectangleList);
                return _rectangleList;
            }
        }

        protected Point CreateSecondPoint(Point point, int heigth)
        {
            return new Point(point.X, point.Y + 2 * heigth);
        }

        protected Point CreateThirdPoint(Point point, int heigth)
        {
            return new Point(point.X, point.Y + 4 * heigth);
        }

        /// <summary>
        /// 算出来卦的整体的宽高
        /// </summary>
        /// <param name="totalWidth"></param>
        /// <param name="heigth"></param>
        /// <param name="midWidth"></param>
        /// <returns></returns>
        protected Rectangle GetGuaRectangle(int totalWidth, int heigth, int midWidth)
        {
            return new Rectangle() { Width = totalWidth, Height = 3 * heigth + 2 * midWidth };

        }

        public string SaveGuaImage()
        {
            Image image = new Bitmap(400, 400);

            Graphics graph = Graphics.FromImage(image);

            graph.Clear(Color.Azure);
            Pen pen = new Pen(Brushes.Red);
            graph.DrawRectangles(pen, this.RectangleList.ToArray());
            graph.FillRectangles(Brushes.Red, this.RectangleList.ToArray());
            graph.DrawString(this.Name, new Font("宋体", 12), Brushes.Red, new PointF(this.GuaRectangle.Width + 20, this.GuaRectangle.Height / 2));
            var guaImagePath = "graph_" + this.Name + ".bmp";
            image.Save(guaImagePath, System.Drawing.Imaging.ImageFormat.Bmp);
            return guaImagePath;
        }
    }
}
