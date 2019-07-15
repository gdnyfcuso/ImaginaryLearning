using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Text;
using Encoder = System.Drawing.Imaging.Encoder;

namespace ImaginaryLearning.Core
{

    /// <summary>
    /// 太极由无极而生
    /// </summary>
    public class TaiJi : WuJi
    {
        public string TaiJiName = "太极";

        private Encoder myEncoder;
        private EncoderParameter myEncoderParameter;
        private EncoderParameters myEncoderParameters;

        public void CreateTaiJiImage(Point midPoint, Graphics graphics, int r = 200)
        {
            //int imgWidth = 400;                 //图象尺寸  
            int eyeRadius = r / 10;      //鱼眼半径  
            int headDiameter = r;    //鱼头直径  

            //Bitmap image = new Bitmap(imgWidth, imgWidth);
            //image.SetResolution(300, 300);

            //Graphics graphics = Graphics.FromImage(image);

            //设置图像质量  
            graphics.CompositingQuality = CompositingQuality.HighQuality;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

            ////底色填充为白色  
            //Brush white = new SolidBrush(Color.White);
            //graphics.FillRectangle(white, new Rectangle(midPoint.X - r, midPoint.Y - r, 2 * r, 2 * r));

            Brush blue = new SolidBrush(Color.Blue);//定义蓝色笔刷  
            Brush red = new SolidBrush(Color.Red);//定义红色笔刷  

            //整个圆形填充蓝色  
            graphics.FillPie(blue, midPoint.X - r, midPoint.Y - r, 2 * r, 2 * r, 0, 360);

            //定义右边的路径（红色部分）  
            GraphicsPath redPath = new GraphicsPath();//初始化路径  
            redPath.AddArc(midPoint.X - r, midPoint.Y - r, 2 * r, 2 * r, 0, -180);
            redPath.AddArc(midPoint.X - r, midPoint.Y - r + headDiameter / 2, headDiameter, headDiameter, 0, -180);
            redPath.AddArc(midPoint.X - r + headDiameter, midPoint.Y - r + headDiameter / 2, headDiameter, headDiameter, 0, 180);

            //填充右边部分  
            graphics.FillPath(red, redPath);

            //填充红色眼睛  
            graphics.FillPie(red, new Rectangle(midPoint.X - headDiameter / 2 - eyeRadius, midPoint.Y - eyeRadius, eyeRadius * 2, eyeRadius * 2), 0, 360);
            //填充蓝色眼睛  
            graphics.FillPie(blue, new Rectangle(midPoint.X + headDiameter / 2 - eyeRadius, midPoint.Y - eyeRadius, eyeRadius * 2, eyeRadius * 2), 0, 360);



            //写入到Response输出流中去，普通质量  
            //image.Save(Response.OutputStream, ImageFormat.Jpeg);  


            //修改图片保存质量  
            ImageCodecInfo myImageCodecInfo = GetEncoder(ImageFormat.Jpeg);
            myEncoder = Encoder.Quality;
            myEncoderParameters = new EncoderParameters(1);
            //图片质量等级  
            myEncoderParameter = new EncoderParameter(myEncoder, 100L);
            myEncoderParameters.Param[0] = myEncoderParameter;
            //graphics
            //return  image;
        }

        public void CreateTaiJiImage()
        {
            int imagWidth = 400;
            Bitmap image = new Bitmap(imagWidth, imagWidth);

            //Bitmap image = new Bitmap(imgWidth, imgWidth);
            image.SetResolution(300, 300);

            Graphics graphics = Graphics.FromImage(image);

            CreateTaiJiImage(new Point(), graphics);
            image.Save("TaiJi.bmp");
            graphics.Dispose();
        }

        private static ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();

            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

    }
}
