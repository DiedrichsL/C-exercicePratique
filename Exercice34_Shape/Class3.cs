using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice34_Shape
{
    public class Circle : Shape
    {

        private double _R { get; set; }

        public Circle(int R, string color, string name) : base (color, name)
        {
            _R = R;
        }

        public override double CalculateArea() 
        {
            double surface = Math.PI * _R * _R;
            return surface;
        }
    }
}
