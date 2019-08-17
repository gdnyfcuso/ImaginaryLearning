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

        /// <summary>
        /// 卦辞对应的象辞
        /// </summary>
        public string GuaXiangCi { get; set; }

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

        /// <summary>
        /// 每一卦对应的拼音
        /// </summary>
        public string PinYin { get; set; }


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
        /// 获取互卦
        /// 互卦：指的是由“交卦”和“互卦”组合而成的新的“六爻卦”；
        /// “交卦”为上卦、客卦，由五爻、四爻、三爻构成；
        /// “互卦”为下卦、主卦，由二爻、三爻、四爻构成。
        /// </summary>
        /// <returns></returns>
        public FuGua GetHuGua() { return null; }

        /// <summary>
        /// 获取变卦
        /// </summary>
        /// <param name="yaoBian">
        /// 第几爻变
        /// </param>
        /// <returns></returns>
        public FuGua GetBianGua(int yaoBian) { return null; }

        /// <summary>
        /// 获取错卦
        /// 错卦：又称“对卦”、“旁通卦”，指阴阳相对的卦（“对卦”也可理解为，在《伏羲先天六十四卦方圆图》的圆图中相对的两卦）。
        /// 错，阴阳相错，也就是把一个“六爻卦”的各个爻求反、求错，就得到该“六爻卦”的错卦。
        /// </summary>
        /// <returns></returns>
        public FuGua GetCuoGua()
        {
            return null;
        }

        /// <summary>
        /// 综卦：又称“反卦”、“覆卦”，指将一个“六爻卦”反覆（颠倒）过来所得到的卦。
        /// 综卦是“六爻卦”旋转180°所得到的卦。
        /// 综卦是角度转换，换一个方向来看“六爻卦”，就得到该“六爻卦”的综卦。
        /// </summary>
        /// <returns></returns>
        public FuGua GetZongGua()
        {
            return null;
        }

        /// <summary>
        /// 序卦传里面的编号
        /// </summary>
        public int XuGua { get; set; }


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
