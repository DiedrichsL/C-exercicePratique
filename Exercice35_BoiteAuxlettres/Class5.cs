using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;



namespace Exercice35_BoiteAuxLettres
{
    public class Publicite : Courrier
    {
        public Publicite(double poids, bool express, string adresseDestination)
            : base(poids, express, adresseDestination)
        {
        }

        public override double CalculerPrix()
        {
            double poidsKg = Poids / 1000.0;
            double montant = 5.0 * poidsKg;

            if (Express)
            {
                montant *= 2;
            }

            return montant;
        }

        public override void Afficher()
        {
            Console.WriteLine("Publicité");
            if (!EstValide())
            {
                Console.WriteLine("(Courrier invalide)");
            }

            Console.WriteLine($"    Poids : {Poids} grammes");
            Console.WriteLine($"    Express : {(Express ? "oui" : "non")}");
            Console.WriteLine($"    Destination : {AdresseDestination}");
            Console.WriteLine($"    Prix : {CalculerPrix():0.0} CHF");
        }
    }
}