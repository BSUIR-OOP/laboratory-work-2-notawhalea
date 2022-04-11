using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork2
{
    public class Ellipse : Figure
    {
        public override int Points { get; set; }

        public Ellipse(int x, int y, int height, int width)
        {

        }

        public Ellipse()
        {
            Points = 3;
        }

        public override void Draw(PaintEventArgs e, List<Point> points)
        {
            Pen pen = new Pen(Color.Black, 3);
            e.Graphics.DrawEllipse(pen, points[0].X - points[1].X / 2, points[0].Y - points[1].Y / 2, points[2].X, points[2].Y);
        }

    }
}

