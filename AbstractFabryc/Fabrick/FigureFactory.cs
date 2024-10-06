using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabryc.Fabrick
{
    public class FigureFactory : IFigureFabrick
    {
        public IDraw CreateFigure(string color, string type)
        {
            Color c = color.ToLower() switch
            {
                "красный" => Color.Red,
                "зеленый" => Color.Green,
                _ => Color.Black,
            };
            return new Figure(c, type);
        }
    }   
}
