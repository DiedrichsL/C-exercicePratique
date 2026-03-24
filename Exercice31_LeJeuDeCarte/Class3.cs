using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace Exercice31_LeJeuDeCarte
{
    public class Deck
    {
     

        private List<Carte> cartes;

        public Deck ()
        {
            cartes = new List<Carte>();
        }
        public void AjouterCarte(Carte carte)
        {
            cartes.Add(carte);
        }

        public Carte TirerUneCarte()
        {
            
            Carte carte = cartes[0];
            cartes.RemoveAt(0);
            return carte;
        }

        public bool EstVide()
        {

            return cartes.Count == 0;
    
        }

        public int NombreDeCartes()
        {
            return cartes.Count;
        }

        public void Melanger()
        {
             Random random = new Random();

            for (int i = 0; i < cartes.Count; i++)
            {
                int indexAleatoire = random.Next(cartes.Count);

                Carte temp = cartes[i];
                cartes[i] = cartes[indexAleatoire];
                cartes[indexAleatoire] = temp;
            }

        }

        public void RecuprerCarteGagnee(List<Carte> cartesGagnees)
        {
            cartes.AddRange(cartesGagnees);
        }

        public void CreerDeckComplet()
        {
            string[] couleurs = { "Coeur", "Carreau", "Trèfle", "Pique" };
            foreach (string couleur in couleurs)
            {
             
                for (int valeur = 2; valeur <= 14; valeur++)

                {
                    Carte carte = new Carte(valeur, couleur);
                    AjouterCarte(carte);
                }
            }

          
        }
    }
}
