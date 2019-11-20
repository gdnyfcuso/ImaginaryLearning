using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core.Base
{
    /// <summary>
    /// 六十四卦所用的坐标系统
    /// </summary>
    public class LiuSiGuaCoordinateSystem
    {
        /// <summary>
        ///创建六十四卦圆图
        /// </summary>
        /// <returns></returns>
        public Bitmap CreateLiuSiGuaBitmap(Bitmap sourceBitmap)
        {
            return null;
        }

        /// <summary>
        /// 创建六十四卦方图
        /// </summary>
        /// <returns></returns>
        public Bitmap CreateLiuSiGuaRectangleBitmap(Bitmap sourceBitmap)
        {
            return null;
        }

        /// <summary>
        /// 通过数字计算复卦
        /// </summary>
        /// <returns></returns>
        public FuGua CreateFuGuaByNumber()
        {
            return null;
        }

        /// <summary>
        /// 通过时间计算复卦
        /// </summary>
        /// <param name="SourceDateTime"></param>
        /// <returns></returns>
        public FuGua CreateFuGuaByDateTime(DateTime SourceDateTime)
        {
            return null;
        }

        /// <summary>
        /// 通过当前时间计算复卦
        /// </summary>
        /// <returns></returns>
        public FuGua CreateFuGuaByCurrentDateTime()
        {
            return null;
        }

        /// <summary>
        /// 通过手机号计算复卦
        /// </summary>
        /// <returns></returns>
        public FuGua CreateFuGuaByPhoneNumber()
        {
            return null;
        }

        /// <summary>
        /// 通过车牌号计算复卦
        /// </summary>
        /// <returns></returns>
        public FuGua CreateFuGuaByCarCard()
        {
            return null;
        }

        /// <summary>
        /// 将复卦画到图像上去
        /// </summary>
        /// <param name="sourceBitmap"></param>
        /// <returns></returns>
        public Bitmap DrawingFuGuaToBitmap(Bitmap sourceBitmap)
        {
            return null;
        }
    }
}
