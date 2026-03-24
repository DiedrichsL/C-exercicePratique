using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice34_Shape
{
    public abstract class Shape
    {
        public string color { get; set; }
        public string name { get; set; }

        public Shape(string color, string name)
        {
            this.color = color;
            this.name = name;
        }
        public void ShowColor()
        { }

        public abstract double CalculateArea();
        
    }
}
