using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice34_Shape
{
    public class Triangle : Shape
    {
        private int _x { get; set; }
        private int _y { get; set; }

        public Triangle(int x, int y, string color, string  name) : base (color, name )

        {
            _x = x;
            _y = y;
        }

        public override double CalculateArea()
        {
            double surface = _x * _y / 2;
            return surface;
        }
    }
}
