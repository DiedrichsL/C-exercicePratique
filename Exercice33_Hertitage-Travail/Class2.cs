using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice33_Hertitage_Travail
{
    public class Employe : Personne
    {
        private double _salaire { get; set; }
    

    public Employe(string nom, string prenom, int age, double salaire) : base(nom, prenom, age)

        {
            _salaire = salaire;
        }
    }
}
