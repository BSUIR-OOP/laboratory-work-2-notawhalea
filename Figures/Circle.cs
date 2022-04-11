using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork2
{
    public class Circle : Figure
    {
        protected int X { get; set; }
        protected int Y { get; set; }
        private int R { get; set; }
        public override int Points { get; set ; }

        public Circle(int x, int y, int R)
        {
            X = x; Y = y; this.R = R;
        }

        public Circle()
        {
            Points = 2;
        }

        override public void Draw(PaintEventArgs e, List<Point> points)
        {
            Pen pen = new Pen(Color.Red, 3);
            R = points[0].X - points[1].X;
            e.Graphics.DrawEllipse(pen, points[0].X - R / 2, points[0].Y - R / 2, R, R);
        }
    }
}
