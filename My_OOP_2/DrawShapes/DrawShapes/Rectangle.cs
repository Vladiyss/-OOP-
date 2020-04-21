using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DrawShapes
{
    class Rectangle : Shape
    {
        public Rectangle(Pen pen, SolidBrush brush, Point firstPoint, Point secondPoint) : base(pen, brush, firstPoint, secondPoint) { }

        public int Width
        {
            get
            {
                return Math.Abs(secondPoint.X - firstPoint.X);
            }
        }

        public int Height
        {
            get
            {
                return Math.Abs(secondPoint.Y - firstPoint.Y);
            }
        }

        public Point topLeftPoint
        {
            get
            {
                int x = Math.Min(firstPoint.X, secondPoint.X);
                int y = Math.Min(firstPoint.Y, secondPoint.Y);
                return new Point(x, y);
            }
        }

        public override void DrawShape(Graphics graphics)
        {
            graphics.DrawRectangle(pen, topLeftPoint.X, topLeftPoint.Y, Width, Height);
            graphics.FillRectangle(brush, topLeftPoint.X, topLeftPoint.Y, Width, Height);
        }
    }
}

