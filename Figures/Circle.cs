using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork2
{
    public class Circle : IFigure
    {
        protected int X { get; set; }
        protected int Y { get; set; }
        private int R { get; set; }

        public Circle(int x, int y, int R)
        {
            X = x; Y = y; this.R = R;
        }

        virtual public void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 3);
            e.Graphics.DrawEllipse(pen, X - R / 2, Y - R / 2, R, R);
        }
    }
}
