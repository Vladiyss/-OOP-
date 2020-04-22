using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawShapes
{
    public partial class Form1 : Form
    {
        int currentShapeNumber = 1;
        Point firstPoint, secondPoint;
        Color color;
        Pen pen;
        SolidBrush brush;
        List<Shape> shapes = new List<Shape>();
        delegate Shape ShapeConstructor();
        static Dictionary<int, ShapeConstructor> shapesConstructors = new Dictionary<int, ShapeConstructor>();
        Graphics graphics;

        public Form1()
        {
            InitializeComponent();
            shapesConstructors.Add(1, () => { return new Line(pen, brush, firstPoint, secondPoint); });
            shapesConstructors.Add(2, () => { return new Circle(pen, brush, firstPoint, secondPoint); });
            shapesConstructors.Add(3, () => { return new Ellipse(pen, brush, firstPoint, secondPoint); });
            shapesConstructors.Add(4, () => { return new Square(pen, brush, firstPoint, secondPoint); });
            shapesConstructors.Add(5, () => { return new Rectangle(pen, brush, firstPoint, secondPoint); });
            shapesConstructors.Add(6, () => { return new Triangle(pen, brush, firstPoint, secondPoint); });
        }

        private void AddShape()
        {
            shapes.Add(shapesConstructors[currentShapeNumber]());   
        }



        private void pictureBoxShapeColor_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = colorDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                pictureBoxShapeColor.BackColor = colorDialog.Color;
                color = colorDialog.Color;
                brush = new SolidBrush(color);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            graphics = pictureBoxPlaceToDraw.CreateGraphics();

            firstPoint.X = 0;
            firstPoint.Y = 0;
            secondPoint.X = 0;
            secondPoint.Y = 0;
            pen = new Pen(Color.White, 5);
            brush = new SolidBrush(Color.Black);
        }

        private void pictureBoxPlaceToDraw_MouseDown(object sender, MouseEventArgs e)
        {
            firstPoint.X = e.X;
            firstPoint.Y = e.Y;
        }

        private void pictureBoxPlaceToDraw_MouseUp(object sender, MouseEventArgs e)
        {
            secondPoint.X = e.X;
            secondPoint.Y = e.Y;
            AddShape();
            DrawShapes(graphics);
        }

        private void pictureBoxPlaceToDraw_Click(object sender, EventArgs e)
        {

        }

        void DrawShapes(Graphics g)
        {
            foreach (Shape shape in shapes)
            {
                shape.DrawShape(graphics);
            }
        }

        private void pictureBoxPlaceToDraw_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            currentShapeNumber = Convert.ToInt32(button.Tag);
        }
    }
}
