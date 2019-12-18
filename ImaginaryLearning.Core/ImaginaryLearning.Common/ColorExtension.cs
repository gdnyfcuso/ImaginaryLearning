using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Common
{
    public static class ColorExtension
    {
        /// <summary>
        /// 计算两个颜色之间的渐变色
        /// </summary>
        /// <param name="A">开始颜色</param>
        /// <param name="B">结束颜色</param>
        /// <param name="step"></param>
        /// <returns>中间渐变色再加上开始和结束的渐变色</returns>
        public static List<Color> GradualChange(this Color A, Color B, int step)
        {
            var colorList = new List<Color>() { };

            var colorA = new List<Color>();
            var colorB = new List<Color>();
            for (int i = 1; i <= step; i++)
            {

                int RA = A.R + (B.R - A.R) * i / step;
                int GA = A.G + (B.G - A.G) * i / step;
                int BA = A.B + (B.B - A.B) * i / step;
                if (i < 5)
                {
                    colorA.Add(Color.FromArgb(RA, GA, BA));
                }
                else
                {
                    colorB.Add(Color.FromArgb(RA, GA, BA));
                }

            }

            colorList.AddRange(colorA);
            var colorC = new List<Color>();
            for (int i = 0; i < colorB.Count; i++)
            {
                colorC.Add(colorB[colorB.Count - i - 1]);
            }
            colorList.AddRange(colorC);
            return colorList;
        }
    }
}
