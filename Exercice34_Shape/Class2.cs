using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Xml.Linq;

namespace Exercice34_Shape
{
    public class Rectangle : Shape 
    {
        private int _x { get; set; }
        private int _y { get; set; }

        public Rectangle(int x, int y, string color, string name) : base(color, name)
        {
          _x = x;
          _y = y;
        }

        public override double CalculateArea()
        {
            double surface = _x * _y;
            return surface;
        }
    }
}
