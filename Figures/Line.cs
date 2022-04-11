using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork2
{
    public class Line : Figure
    {
        
        public override int Points { get; set; }

        public Line(int x1, int y1, int x2, int y2)
        {
            
        }

        public Line()
        {
            Points = 2;  
        }

        public override void Draw(PaintEventArgs e, List<Point> points)
        {
            Pen pen = new Pen(Color.Black, 3);
            e.Graphics.DrawLine(pen, points[0].X, points[0].Y, points[1].X, points[1].Y);
        }
    }
}