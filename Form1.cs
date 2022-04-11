using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork2
{
    public partial class Form1 : Form
    {

        Rectangle rectangle = new Rectangle();

        Square square = new Square();

        Triangle triangle = new Triangle();

        Line line = new Line();

        Ellipse ellipse = new Ellipse();

        Circle circle = new Circle();

        ListFigures figures;

        List<Point> points;

        public Form1()
        {
            InitializeComponent();
            
            ChooseFigure.Items.Add(rectangle);
            ChooseFigure.Items.Add(square);
            ChooseFigure.Items.Add(triangle);
            ChooseFigure.Items.Add(line);
            ChooseFigure.Items.Add(circle);
            ChooseFigure.Items.Add(ellipse);
            figures = new ListFigures();

            points = new List<Point>();
        }

        private void ChooseFigure_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics g;
            g = this.CreateGraphics();

            PaintEventArgs arg;

            System.Drawing.Rectangle r = new System.Drawing.Rectangle();

            arg = new PaintEventArgs(g, r);



            points.Add(new Point(e.X, e.Y));



            Figure figure = (Figure)ChooseFigure.SelectedItem;

            

            if (figure.Points == points.Count)
            {
                figure.Draw(arg, points);

                points.Clear();
            }            
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }
    }
}
