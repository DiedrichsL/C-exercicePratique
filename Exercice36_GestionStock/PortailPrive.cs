using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Exercice36_GestionStock
{
    public class PortailPrive : Portail
    {

        public PortailPrive()    : base()
        
        
        { 
            
        }
        
       

        public void MotDePasse()
        {
            string [] mdp = File.ReadAllLines(@"C:\Users\41796\Dropbox\Mon PC (LAPTOP-1OIEEFR2)\Desktop\Brevet fédéral d'informaticien\C#\Session 8\FichierMotDePasse.txt");


            Console.WriteLine("Entrez votre mot de passe : ");
            
            string mdp2 = Console.ReadLine();
           do 
                
            if (mdp2 == mdp[0])
            {
                Console.WriteLine(" Mot de passe correct");
            }
            else
            {
                Console.WriteLine("Mot de passe incorrect");
            }
           while (mdp2 != mdp[1]);
           
                  
           
        }





        Stock s = new Stock();
        s.AjouterArticle(int numRef, string nom, double prix, int type)
         s.ModifierArticle(int numRef, double nouveauPrix, string nouveauNom, int nouveauNumRef);

    }



}
