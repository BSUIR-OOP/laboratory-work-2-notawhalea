using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork2
{
    public class Triangle : Figure
    {
        protected int X1 { get; set; }
        protected int X2 { get; set; }
        protected int X3 { get; set; }
        protected int Y1 { get; set; }
        protected int Y2 { get; set; }
        protected int Y3 { get; set; }

        public override int Points { get; set; }

        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            X1 = x1; X2 = x2; Y1 = y1; Y2 = y2; X3 = x3; Y3 = y3;
        }

        public Triangle()
        {
            Points = 3;
        }

        protected (int, int) SwapPoints(int x1, int x2)
        {
            (x1, x2) = (x2, x1);
            return (x1, x2);
        }

        public override void Draw(PaintEventArgs e, List<Point> points)
        {
            Pen pen = new Pen(Color.Black, 3);
            e.Graphics.DrawLine(pen, points[0].X, points[0].Y, points[1].X, points[1].Y);
            e.Graphics.DrawLine(pen, points[1].X, points[1].Y, points[2].X, points[2].Y);
            e.Graphics.DrawLine(pen, points[2].X, points[2].Y, points[0].X, points[0].Y);
        }
    }
}