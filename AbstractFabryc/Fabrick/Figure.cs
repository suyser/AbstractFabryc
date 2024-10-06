using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabryc.Fabrick
{
    public class Figure : IDraw
    {
        private Color color;
        private string type;

        public Figure(Color color, string type)
        {
            this.color = color;
            this.type = type;
        }

        public void Draw(Graphics g, Point location)
        {
            switch (type)
            {
                case "Круг":
                    g.FillEllipse(new SolidBrush(color), new Rectangle(location.X, location.Y, 50, 50));
                    break;
                case "Квадрат":
                    g.FillRectangle(new SolidBrush(color), new Rectangle(location.X, location.Y, 50, 50));
                    break;
                case "Треугольник":
                    Point[] points = new Point[] { new Point(location.X, location.Y), new Point(location.X + 50, location.Y), new Point(location.X + 25, location.Y + 50) };
                    g.FillPolygon(new SolidBrush(color), points);
                    break;
            }
        }
    }
}
