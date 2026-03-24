using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice35_BoiteAuxLettres
{
    public abstract class Courrier
    {
        public double Poids { get; set; }           
        public bool Express { get; set; }              
        public string AdresseDestination { get; set; }

        public Courrier(double poids, bool express, string adresseDestination)
        {
            Poids = poids;
            Express = express;
            AdresseDestination = adresseDestination;
        }

        public virtual bool EstValide()
        {
            return !string.IsNullOrWhiteSpace(AdresseDestination);
        }

        public abstract double CalculerPrix();

        public abstract void Afficher();
    }
}