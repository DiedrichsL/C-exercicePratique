using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice33_Hertitage_Travail
{
    public  class Personne
    {
        private string _nom { get; set; }
        private string _prenom { get; set; }
        private int _age { get; set; } 


        public Personne(string nom, string prenom, int age) 
        
        {
            _nom = nom;
            _prenom = prenom;
            _age = age;
        }

    }
}

