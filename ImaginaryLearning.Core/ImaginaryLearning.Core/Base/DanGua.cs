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
        public DanGua()
        {
            _rectangleList = new List<Rectangle>();
        }

        public Yao ChuYao { get; set; }

        public Yao ErYao { get; set; }

        public Yao SanYao { get; set; }

        public string Name { get; set; }

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
    }
}
