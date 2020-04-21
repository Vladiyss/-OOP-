using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DrawShapes
{
    abstract class Shape
    {
        internal Pen pen;
        internal Point firstPoint, secondPoint;
        internal SolidBrush brush;

        public Shape(Pen pen, SolidBrush brush, Point firstPoint, Point secondPoint)
        {
            this.pen = pen;
            this.brush = brush;
            this.firstPoint = firstPoint;
            this.secondPoint = secondPoint;
        }

        public abstract void DrawShape(Graphics graphics);
    }
}
