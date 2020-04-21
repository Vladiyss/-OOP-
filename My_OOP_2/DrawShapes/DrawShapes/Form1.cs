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
        static Dictionary<int, Shape> shapesDictionary = new Dictionary<int, Shape>();
        Graphics graphics;

        public Form1()
        {
            InitializeComponent();
        }

        private void AddShapesToDictionary()
        {
            shapesDictionary.Add(1, new Line(new Pen(color, 5), brush, firstPoint, secondPoint));
            shapesDictionary.Add(2, new Circle(pen, brush, firstPoint, secondPoint));
            shapesDictionary.Add(3, new Ellipse(pen, brush, firstPoint, secondPoint));
            shapesDictionary.Add(4, new Square(pen, brush, firstPoint, secondPoint));
            shapesDictionary.Add(5, new Rectangle(pen, brush, firstPoint, secondPoint));
            shapesDictionary.Add(6, new Triangle(pen, brush, firstPoint, secondPoint));
            
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
            AddShapesToDictionary();
            shapesDictionary[currentShapeNumber].DrawShape(graphics);
            shapesDictionary.Clear();
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            currentShapeNumber = Convert.ToInt32(button.Tag);
        }
    }
}
