using System;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;

namespace Exercice31_LeJeuDeCarte
{
    public class Carte
    {
       

        public int Valeur { get; set; }
        public string Couleur { get; set; }

        



        public Carte(int valeur, string couleur)
        {
            Valeur = valeur;
            Couleur = couleur;
            
        }

        public int ComparerCarte(Carte adversaire)
        {

            if (Valeur > adversaire.Valeur)

            {
                return +1;
            }
            else if (Valeur < adversaire.Valeur)
            {
               return -1;
            }

            else

            {
                return 0;
            }

      
        }

        public bool EstPlusForteQue(Carte adversaire)
        {
            return ComparerCarte(adversaire) == +1;
        }



        public override string ToString()
        {

            string ValeurAffichee;
            switch (Valeur)
            {
                case 11: ValeurAffichee = "J";
                    break;
                case 12:
                    ValeurAffichee = "Q";
                    break;
                case 13:
                    ValeurAffichee = "K";
                    break;
                case 14:
                    ValeurAffichee = "A";
                    break;

                default:
                    ValeurAffichee = Valeur.ToString();

                    break;
            }

            return $"{ValeurAffichee} de {Couleur}";

       
        }

    }

     

     

}
    
