using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;



namespace Exercice35_BoiteAuxLettres
{
    public class BoiteAuxLettres
    {
        private List<Courrier> courriers;

        public BoiteAuxLettres()
        {
            courriers = new List<Courrier>();
        }

        public void Ajouter(Courrier courrier)
        {
            courriers.Add(courrier);
        }

        public double Affranchir()
        {
            double total = 0;

            foreach (Courrier courrier in courriers)
            {
                if (courrier.EstValide())
                {
                    total += courrier.CalculerPrix();
                }
            }

            return total;
        }

        public void CourrierInvalide()
        {
            int compteur = 0;

            foreach (Courrier courrier in courriers)
            {
                if (!courrier.EstValide())
                {
                    compteur++;
                }
            }

            Console.WriteLine($"Nombre de courriers non valides : {compteur}");
        }

        public void Afficher()
        {
            foreach (Courrier courrier in courriers)
            {
                courrier.Afficher();
                Console.WriteLine();
            }
        }
    }
}