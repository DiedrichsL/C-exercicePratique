using System;
using System.Collections.Generic;
using System.Text;



namespace Exercice35_BoiteAuxLettres
{
    public class Lettre : Courrier
    {
        public string Format { get; set; }

        public Lettre(double poids, bool express, string adresseDestination, string format)
            : base(poids, express, adresseDestination)
        {
            Format = format;
        }

        public override double CalculerPrix()
        {
            double poidsKg = Poids / 1000.0;
            double tarifBase = 0.0;

            if (Format == "A4")
            {
                tarifBase = 2.50;
            }
            else if (Format == "A3")
            {
                tarifBase = 3.50;
            }

            double montant = tarifBase + 1.0 * poidsKg;

            if (Express)
            {
                montant *= 2;
            }

            return montant;
        }

        public override void Afficher()
        {
            Console.WriteLine("Lettre");
            if (!EstValide())
            {
                Console.WriteLine("(Courrier invalide)");
            }

            Console.WriteLine($"    Poids : {Poids} grammes");
            Console.WriteLine($"    Express : {(Express ? "oui" : "non")}");
            Console.WriteLine($"    Destination : {AdresseDestination}");
            Console.WriteLine($"    Prix : {CalculerPrix():0.0} CHF");
            Console.WriteLine($"    Format : {Format}");
        }
    }
}