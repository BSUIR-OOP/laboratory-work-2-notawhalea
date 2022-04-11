using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork2
{ 
class ListFigures
{
    private List<Figure> figures;

    public ListFigures()
    {
        figures = new List<Figure>();
        //AddFigure(new Rectangle());
        //AddFigure(new Square());
        //AddFigure(new Rhomb());
        //AddFigure(new Circle());
        //AddFigure(new Ellipse());
        //AddFigure(new Triangle());
        }

    public void AddFigure(Figure figure)
    {
        figures.Add(figure);
    }

    public void PrintFigures(Figure figure)
    {

    }
}
}
