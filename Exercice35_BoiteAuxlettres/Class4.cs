using System;
using System.Collections.Generic;
using System.Text;



namespace Exercice35_BoiteAuxLettres
{
    public class Colis : Courrier
    {
        public double Volume { get; set; }  

        public Colis(double poids, bool express, string adresseDestination, double volume)
            : base(poids, express, adresseDestination)
        {
            Volume = volume;
        }

        public override bool EstValide()
        {
            return base.EstValide() && Volume <= 50;
        }

        public override double CalculerPrix()
        {
            double poidsKg = Poids / 1000.0;
            double montant = 0.25 * Volume + poidsKg * 1.0;

            if (Express)
            {
                montant *= 2;
            }

            return montant;
        }

        public override void Afficher()
        {
            Console.WriteLine("Colis");
            if (!EstValide())
            {
                Console.WriteLine("(Courrier invalide)");
            }

            Console.WriteLine($"    Poids : {Poids} grammes");
            Console.WriteLine($"    Express : {(Express ? "oui" : "non")}");
            Console.WriteLine($"    Destination : {AdresseDestination}");
            Console.WriteLine($"    Prix : {CalculerPrix():0.0} CHF");
            Console.WriteLine($"    Volume : {Volume} litres");
        }
    }
}