using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice28_LeRectangle
{
    internal class Rectangle
    {
        public int Hauteur { get; set; }
        public int Largeur { get; set; }



        public Rectangle(int hauteur, int largeur)
        {
            Hauteur = hauteur;
            Largeur = largeur;
        }

        public int GetSurface()
        {
            return Hauteur * Largeur;
        }


    }  
  
}
