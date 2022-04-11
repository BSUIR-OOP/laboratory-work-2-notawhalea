using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork2
{
    public abstract class Figure
    {
        public abstract int Points { get; set; }
        public virtual void Draw(PaintEventArgs e, List<Point> points)
        {

        }
    }
}
