using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercice31_LeJeuDeCarte
{
    public class Partie
    {
        public Joueur Joueur1 { get; set; }
        public Joueur Joueur2 { get; set; }


        public Partie(Joueur joueur1, Joueur joueur2)
        { 
          Joueur1 = joueur1;
          Joueur2 = joueur2;
        }

        public void Demarrer()
        {
            Deck deckCentral = new Deck();
            deckCentral.CreerDeckComplet();
            deckCentral.Melanger();
            Distribuer(deckCentral);

            do

            { JouerManche(); }

            while (!EstTerminee() );

            AfficherGagnant();
        }

        public void Distribuer(Deck deckCentral)
        {
            while (deckCentral.NombreDeCartes() >= 2)
            {
                Carte carte1;
                Carte carte2;

                carte1 = deckCentral.TirerUneCarte();
                Joueur1.Deck.AjouterCarte(carte1);
                carte2 = deckCentral.TirerUneCarte();
                Joueur2.Deck.AjouterCarte(carte2);
            }



        }

        public void JouerManche()
        {
           Carte carteJ1 = Joueur1.JouerCarte();
           Carte carteJ2= Joueur2.JouerCarte();
           int resultat = carteJ1.ComparerCarte(carteJ2);

            List<Carte> cartesGagnees = new List<Carte>();
            cartesGagnees.Add(carteJ1);
            cartesGagnees.Add(carteJ2);


            if (resultat == 1)
            {
                
                Joueur1.RecevoirCarte(cartesGagnees);
            }

            else if (resultat == -1)
            {
               
                Joueur2.RecevoirCarte(cartesGagnees);
            }

            else
            {
                GererBataille(cartesGagnees);
            }

            


        }

        public void GererBataille(List<Carte> cartesGagnees)
        {

            if (Joueur1.Deck.NombreDeCartes() < 2 || Joueur2.Deck.NombreDeCartes() < 2)
            {
                AfficherGagnant();
                return;
            }

            Carte carteCacheeJ1 = Joueur1.JouerCarte();
            cartesGagnees.Add(carteCacheeJ1);
            Carte carteVisibleJ1 = Joueur1.JouerCarte();
            cartesGagnees.Add(carteVisibleJ1);


            
          
            Carte carteCacheeJ2 = Joueur2.JouerCarte();
            cartesGagnees.Add(carteCacheeJ2);
            Carte carteVisibleJ2 = Joueur2.JouerCarte();
            cartesGagnees.Add(carteVisibleJ2);


            int resultat = carteVisibleJ1.ComparerCarte(carteVisibleJ2);
            if (resultat == 1)
            {
                Joueur1.RecevoirCarte(cartesGagnees);
            }

            else if (resultat == -1)
            {
                Joueur2.RecevoirCarte(cartesGagnees);
            }
            else
            {
                GererBataille(cartesGagnees);
            }
        }

        public bool EstTerminee()
        {
            return !Joueur1.AvoirEncoreCarte() || !Joueur2.AvoirEncoreCarte();
        }

        public void AfficherGagnant()
        {
            if (Joueur1.AvoirEncoreCarte())
            {
                Console.WriteLine($"Le gagnant est {Joueur1.Pseudo}");
            }
            else
            {
                Console.WriteLine($"Le gagnant est {Joueur2.Pseudo}");
            }
        }
    }



}


