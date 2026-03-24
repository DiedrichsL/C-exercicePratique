using Exercice27_Agent;
using System.Security.AccessControl;

namespace Exercice30_M16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Agence a1 = new Agence("M16");
            Agent bond = new Agent("Bond", "James");
            Agent Tanner = new Agent("Tanner", "Bill");
            a1.AjouterAgent(bond);
            a1.AjouterAgent(Tanner);

            Agence a2 = new Agence("OSS");
            Agent Bonisseur = new Agent("Bonisseur", "Hubert");
            a2.AjouterAgent(Bonisseur);

            a1.AfficherAgence();
            a1.IntroduireTousLesAgents();
            a2.AfficherAgence();
            a2.IntroduireTousLesAgents();
        }
    }
}
