using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork2
{
    public class Square : Rectangle, IFigure
    {
        public Square(int x1, int y1, int x2, int y2) : base(x1, y1, x2, y2)
        {

        }

        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 3);
            e.Graphics.DrawRectangle(pen, X1, Y1, X2 - X1, Y2 - Y1);
        }
       
    }
}