using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DrawShapes
{
    class Line : Shape
    {
        public Line(Pen pen, SolidBrush brush, Point firstPoint, Point secondPoint) : base(pen, brush, firstPoint, secondPoint) { }

        public override void DrawShape(Graphics graphics)
        {
            graphics.DrawLine(pen, firstPoint, secondPoint);
        }
    }
}
