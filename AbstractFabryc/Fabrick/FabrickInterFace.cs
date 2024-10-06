using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabryc.Fabrick
{
    public interface IDraw
    {
        void Draw(Graphics g, Point location);
    }
    public interface IFigureFabrick
    {
        IDraw CreateFigure(string color, string type);
    }
}
