using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork2
{
    public class Ellipse : Circle
    {
        private int Width { get; set; }
        private int Height { get; set; }
        public Ellipse(int x, int y, int height, int width) : base(x, y, height)
        {
            Width = width;
            Height = height;
        }

        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 3);
            e.Graphics.DrawEllipse(pen, X - Width / 2, Y - Height / 2, Width, Height);
        }

    }
}

