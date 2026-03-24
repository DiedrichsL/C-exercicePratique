using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice29_CompteBancaire
{
    internal class CompteBancaire
    {
        private string _nomBeneficiaire {  get; set; }
        private decimal _montant { get; set; }

        public CompteBancaire(string nombeneficiaire)
        {
            _nomBeneficiaire = nombeneficiaire;
            _montant = 0;
        }


        public void AdditionMontant(decimal montant)

        {
            _montant += montant;

        }
        

    

        public void SoustractionMontant(decimal montant)
        {


            if (_montant - montant < 0)
            {
                Console.WriteLine("L'opération ne peut pas être effectuée");
                return;
            }
           
         

                _montant -= montant;

            
        }

        public void AfficherMontant()
        {
            Console.WriteLine(@$"Le montant sur le compte de {_nomBeneficiaire} est de {_montant}");
        }

    }
}
