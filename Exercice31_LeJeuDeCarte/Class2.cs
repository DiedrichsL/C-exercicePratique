using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Exercice31_LeJeuDeCarte
{
    public class Joueur
    {
        public string Pseudo { get; set; }
        public  Deck Deck { get; set; }

        public Joueur(string pseudo, Deck deck)
        {
            Pseudo = pseudo;
            Deck = deck;
        }

    


        public Carte JouerCarte()
        {
            return Deck.TirerUneCarte();
        }

        public void RecevoirCarte(List<Carte> cartesGagnees)
        {
          
            Deck.RecuprerCarteGagnee(cartesGagnees);
           
        }

        public bool AvoirEncoreCarte()
        {
            return !Deck.EstVide();
        }
    }
}
