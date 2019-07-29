using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core.Model
{
    public class YaoRectangle:YaoRectangleBase<Point>
    {
        public Rectangle SourceRectangle { get; set; }
    }
}
