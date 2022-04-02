using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork2
{
    public class Rhomb : Rectangle, IFigure
    {

        public Rhomb(int x1, int y1, int x2, int y2) : base(x1, y1, x2, y2)
        {

        }

        override public void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 3);
            e.Graphics.DrawLine(pen, X1, Y1, X2, Y2);
            e.Graphics.DrawLine(pen, X2, Y2, X2 + 50, Y2);
            e.Graphics.DrawLine(pen, X1, Y1, X1 + 50, Y1);
            e.Graphics.DrawLine(pen, X2 + 50, Y2, X1 + 50, Y1);
        }

    }
}