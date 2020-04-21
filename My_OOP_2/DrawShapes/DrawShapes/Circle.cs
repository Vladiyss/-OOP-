using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DrawShapes
{
    class Circle : Ellipse
    {
        public Circle(Pen pen, SolidBrush brush, Point firstPoint, Point secondPoint) : base(pen, brush, firstPoint, secondPoint) { }

        public override void DrawShape(Graphics graphics)
        {
            graphics.DrawEllipse(pen, topLeftPoint.X, topLeftPoint.Y, Width, Width);
            graphics.FillEllipse(brush, topLeftPoint.X, topLeftPoint.Y, Width, Width);
        }
    }
}

