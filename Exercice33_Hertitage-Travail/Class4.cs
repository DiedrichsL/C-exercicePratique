using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice33_Hertitage_Travail
{
    public  class Directeur : Chef
    {
        private string _societe { get; set; }

        public Directeur(string nom, string prenom, int age, double salaire, string service, string societe) : base(nom, prenom, age, salaire, service)

            {
               _societe = societe;

            }
    }
}
