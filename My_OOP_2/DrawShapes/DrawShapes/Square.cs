using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DrawShapes
{
    class Square : Rectangle
    {
        public Square(Pen pen, SolidBrush brush, Point firstPoint, Point secondPoint) : base(pen, brush, firstPoint, secondPoint) { }

        public override void DrawShape(Graphics graphics)
        {
            graphics.DrawRectangle(pen, topLeftPoint.X, topLeftPoint.Y, Width, Width);
            graphics.FillRectangle(brush, topLeftPoint.X, topLeftPoint.Y, Width, Width);
        }
    }
}
