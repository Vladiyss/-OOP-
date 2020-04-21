using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DrawShapes
{
    class Triangle : Shape
    {
        Point[] pointArray;
        Point leftPoint, topPoint, rightPoint;

        public Triangle(Pen pen, SolidBrush brush, Point firstPoint, Point secondPoint) : base(pen, brush, firstPoint, secondPoint) { }

        public void FindWayToDraw()
        {
            if ((firstPoint.X < secondPoint.X) && (firstPoint.Y < secondPoint.Y))
            {
                topPoint.X = ((secondPoint.X - firstPoint.X) / 2) + firstPoint.X;
                topPoint.Y = firstPoint.Y;
                leftPoint.X = firstPoint.X;
                leftPoint.Y = secondPoint.Y;
                rightPoint.X = secondPoint.X;
                rightPoint.Y = secondPoint.Y;
            }
            else if ((firstPoint.X < secondPoint.X) && (firstPoint.Y > secondPoint.Y))
            {
                topPoint.X = ((secondPoint.X - firstPoint.X) / 2) + firstPoint.X;
                topPoint.Y = secondPoint.Y;
                leftPoint.X = firstPoint.X;
                leftPoint.Y = firstPoint.Y;
                rightPoint.X = secondPoint.X;
                rightPoint.Y = firstPoint.Y;
            }
            else if ((firstPoint.X > secondPoint.X) && (firstPoint.Y < secondPoint.Y))
            {
                topPoint.X = firstPoint.X - ((firstPoint.X - secondPoint.X) / 2);
                topPoint.Y = firstPoint.Y;
                leftPoint.X = secondPoint.X;
                leftPoint.Y = secondPoint.Y;
                rightPoint.X = firstPoint.X;
                rightPoint.Y = secondPoint.Y;
            }
            else
            {
                topPoint.X = firstPoint.X - ((firstPoint.X - secondPoint.X) / 2);
                topPoint.Y = secondPoint.Y;
                leftPoint.X = secondPoint.X;
                leftPoint.Y = firstPoint.Y;
                rightPoint.X = firstPoint.X;
                rightPoint.Y = firstPoint.Y;
            }
            pointArray = new Point[] { leftPoint, topPoint, rightPoint };
        }

        public override void DrawShape(Graphics graphics)
        {
            FindWayToDraw();
            graphics.DrawPolygon(pen, pointArray);
            graphics.FillPolygon(brush, pointArray);
        }
    }
}
