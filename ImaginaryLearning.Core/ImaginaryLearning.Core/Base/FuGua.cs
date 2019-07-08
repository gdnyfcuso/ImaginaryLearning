using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 复卦，由两个单卦组成从下往上，依次是下卦，上卦
    /// </summary>
    public class FuGua
    {
        private List<Rectangle> _rectangleList;

        /// <summary>
        /// 爻词
        /// </summary>
        public string[] YaoCi { get; set; }

        public FuGua()
        {
            _rectangleList = new List<Rectangle>();
        }

        /// <summary>
        /// 下卦
        /// </summary>
        public DanGua XiaGua { get; set; }

        /// <summary>
        /// 上卦
        /// </summary>
        public DanGua ShangGua { get; set; }

        /// <summary>
        /// 复卦名字
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 是否是十二辟卦
        /// </summary>
        public bool IsTwelvePIGua { get; set; } = false;


        protected Point CreateXiaGuaPoint(Point point, int heigth)
        {
            return new Point(point.X, point.Y + 6 * heigth);
        }

        public List<Rectangle> RectangleList
        {
            get
            {
                this._rectangleList.AddRange(XiaGua.RectangleList);
                this._rectangleList.AddRange(ShangGua.RectangleList);
                return _rectangleList;
            }
        }

        /// <summary>
        /// 爻辞所在的索引
        /// </summary>
        /// <param name="yaoCiIndex"></param>
        /// <returns></returns>
        public string GetYaoCi(int yaoCiIndex)
        {
            if (YaoCi != null && YaoCi.Length > yaoCiIndex)
            {
                return YaoCi[yaoCiIndex];
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
