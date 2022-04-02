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
        List<Point> list;
        public Form1()
        {
            InitializeComponent();
            ChooseFigure.Items.Add("Rectangle");
            ChooseFigure.Items.Add("Square");
            ChooseFigure.Items.Add("Rhomb");
            ChooseFigure.Items.Add("Circle");
            ChooseFigure.Items.Add("Ellipse");
            ChooseFigure.Items.Add("Triangle");
            list = new List<Point>();
        }

        private void ChooseFigure_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        //    switch (ChooseFigure.SelectedItem)
        //    {
        //        case "Rectangle":
        //            rectangle = new Rectangle(list[0].X, list[1].X, list[0].Y, list[1].Y);
        //            list.Clear();
        //            rectangle.Draw1(e);
        //            break;
        //        case "Square":
        //            break;
        //        case "Rhomb":
        //            break;
        //        case "Circle":
        //            break;
        //        case "Ellipse":
        //            break;
        //        case "Triangle":
        //            break;
        //        default:
        //            break;
        //    }

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics g;
            g = this.CreateGraphics();

            PaintEventArgs arg;
            System.Drawing.Rectangle r = new System.Drawing.Rectangle();
            arg = new PaintEventArgs(g, r);

            int x = e.X;
            int y = e.Y;

            switch (ChooseFigure.SelectedItem)
            {
                case "Rectangle":
                    Rectangle rectangle = new Rectangle(x, y, x + 100, y + 150);
                    rectangle.Draw(arg);
                    break;
                case "Square":
                    Square square = new Square(x, y, x + 50, y + 50);
                    square.Draw(arg);
                    break;
                case "Rhomb":
                    Rhomb rhomb = new Rhomb(x, y, x + 50, y + 50);
                    rhomb.Draw(arg);
                    break;
                case "Circle":                                      
                    Circle circle = new Circle(x, y, 100);
                    circle.Draw(arg);
                    break;
                case "Ellipse":
                    Ellipse ellipse = new Ellipse(x, y, 100, 50);
                    ellipse.Draw(arg);
                    break;
                case "Triangle":
                    Triangle triangle = new Triangle(x, y, x - 20, y - 100, x + 100, y + 50);
                    triangle.Draw(arg);
                    break;
                default:
                    break;
            }

            //Rectangle rectangle = new Rectangle();
            
        }

       

        private void Clear_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
