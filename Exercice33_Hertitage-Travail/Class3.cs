using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice33_Hertitage_Travail
{
    public  class Chef : Employe
    {
        private string _service { get; set; }
   

   public Chef(string nom, string prenom, int age, double salaire, string service) : base(nom, prenom, age, salaire)

        {
            _service = service;
        }


    }  

}


