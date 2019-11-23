using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 风山渐
    /// </summary>
    public class JianA : FuGua
    {
        public JianA(PointF startPoint, int totalWidth, int midWidth, int heigth) : base(startPoint, totalWidth, midWidth, heigth)
        {
        }

        protected override void InitFuGua(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            ShangGua = new Xun(startPoint, totalWidth, midWidth, heigth);
            XiaGua = new Gen(CreateXiaGuaPoint(startPoint, heigth), totalWidth, midWidth, heigth);
            Name = "渐";
            PinYin = "Jian";
            GuaCi = "女归吉，利贞。";
            XuGua = 53;
            GuaXiangCi = "《象》曰：山上有木，渐。君子以居贤德善俗。";
            TuanCi = "《彖》曰：渐之进也，女归吉也。进得位，往有功也。进以正，可以正邦也。其位刚得中也。止而巽，动不穷也。";
            YaoCi = new string[]
            {
                "初六，鸿渐于干。小子厉，有言，无咎。",
                "六二，鸿渐于磐，饮食衎衎，吉。",
                "九三，鸿渐于陆。夫征不复，妇孕不育，凶。利御寇。",
                "六四，鸿渐于木，或得其桷，无咎。",
                "九五，鸿渐于陵，妇三岁不孕，终莫之胜，吉。",
                "上九，鸿渐于陆，其羽可用为仪，吉。"
            };
            XiangCi = new string[]
            {
                "《象》曰：“小子之厉”，义无咎也。",
                "《象》曰：“饮食衎衎”，不素饱也。",
                "《象》曰：“夫征不复”，离群丑也。“妇孕不育”，失其道也。“利用御寇”，顺相保也。",
                "《象》曰：“或得其桷”，顺以巽也。",
                "《象》曰：“终莫之胜吉”，得所愿也。",
                "《象》曰：“其羽可用为仪，吉”，不可乱也。"
            };
        }
    }
}
