using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 复卦，由两个单卦组成从下往上，依次是下卦，上卦
    /// </summary>
    public abstract class FuGua
    {
        private List<RectangleF> _rectangleList;

        /// <summary>
        /// 爻辞
        /// </summary>
        public string[] YaoCi { get; set; }

        /// <summary>
        /// 象辞
        /// </summary>
        public string[] XiangCi { get; set; }

        /// <summary>
        /// 彖辞
        /// </summary>
        public string TuanCi { get; set; }

        public FuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            _rectangleList = new List<RectangleF>();
            InitFuGua(startPoint, totalWidth, midWidth, heigth);
            SetRectangleF();
        }

        /// <summary>
        /// 初始化六十四卦
        /// </summary>
        /// <param name="startPoint"></param>
        /// <param name="totalWidth"></param>
        /// <param name="midWidth"></param>
        /// <param name="heigth"></param>
        protected abstract void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth);

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

        /// <summary>
        /// 六十四卦每一卦的矩形大小
        /// </summary>
        public RectangleF RectangleF { get; set; }

        /// <summary>
        /// 卦辞
        /// </summary>
        public string GuaCi { get; set; }


        protected PointF CreateXiaGuaPoint(PointF point, int heigth)
        {
            return new PointF(point.X, point.Y + 6 * heigth);
        }

        public List<RectangleF> RectangleList
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

        /// <summary>
        /// 象辞所在的索引
        /// </summary>
        /// <param name="yaoCiIndex"></param>
        /// <returns></returns>
        public string GetXiangCi(int yaoCiIndex)
        {
            if (XiangCi != null && XiangCi.Length > yaoCiIndex)
            {
                return XiangCi[yaoCiIndex];
            }
            else
            {
                return string.Empty;
            }
        }


        /// <summary>
        /// 设备六十四卦的大小
        /// </summary>
        protected virtual void SetRectangleF()
        {
            var heigth = ShangGua.GuaRectangle.Height + XiaGua.GuaRectangle.Height;

            heigth += heigth / 6;

            RectangleF = new RectangleF(0, 0, ShangGua.GuaRectangle.Width, heigth);
        }
    }
}
