using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;

namespace ImaginaryLearning.Common
{
    /// <summary>
    /// 图片扩展类
    /// </summary>
    public static class ImageExtension
    {
        public static void alphaImage(this Bitmap fImage, Bitmap bImage, double alpha)
        {
            //输入fImage为前景图，bImage为背景图，alpha为透明度
            int height = fImage.Height;
            int width = bImage.Width;
            Bitmap aImage = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int Ra = (int)Math.Round((1 - (alpha / 100.0)) * fImage.GetPixel(x, y).R + (alpha / 100.0) * bImage.GetPixel(x, y).R);
                    int Ga = (int)Math.Round((1 - (alpha / 100.0)) * fImage.GetPixel(x, y).G + (alpha / 100.0) * bImage.GetPixel(x, y).G);
                    int Ba = (int)Math.Round((1 - (alpha / 100.0)) * fImage.GetPixel(x, y).B + (alpha / 100.0) * bImage.GetPixel(x, y).B);
                    Color RGB = Color.FromArgb(Ra, Ga, Ba);
                    aImage.SetPixel(x, y, RGB);
                }
            }
            fImage = aImage;
        }
    }
}
