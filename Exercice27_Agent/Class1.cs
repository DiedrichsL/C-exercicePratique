using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice27_Agent
{
    public class Agent
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public Agent(string nom, string prenom)

        {
            Nom = nom;
            Prenom = prenom;
        }


        public void Introduction()
        {
            Console.WriteLine(@$"Mon nom est {Nom}. {Prenom} {Nom}");
        }

    }
}
