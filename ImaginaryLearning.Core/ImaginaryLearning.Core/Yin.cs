/*******************************************************
 * 
 * 作者：李行周
 * 创建日期：20190609
 * 说明：此文件只包含一个类，具体内容见类型注释。
 * 运行环境：.NET 4.5.2
 * 版本号：1.0.0
 * 
 * 历史记录：
 * 创建文件 李行周 20190609 10:20 910428123 
 * 
*******************************************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace ImaginaryLearning.Core
{
    /// <summary>
    /// 易经里面最基本的表示状态相当于二进制的0
    /// </summary>
    public class Yin:TaiJi
    {
        public new string Name { get; } = "阴";
    }
}
